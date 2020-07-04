using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace _896_Tool
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private IDictionary<int, Household> village = null;

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult  result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileTextBox.Text = fileDialog.FileName;
                load();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderTextbox.Text == null || folderTextbox.Text == "")
            {
                MessageBox.Show("Chọn thư mục");
            }
            else
            {
                string folderPath = folderTextbox.Text;
                Excel.Application excelApplication = new Excel.Application(); ;
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;

                foreach (KeyValuePair<int, Household> household in village)
                {
                    string id = household.Key < 10 ? "0" + household.Key : household.Key.ToString();
                    string mainMemberName = household.Value.MainMember.Name;
                    string fileName = folderPath + @"\" + id.ToString() + " " + mainMemberName + ".xlsx";
                    int pageNum = (int) Math.Ceiling(household.Value.NumMembers / 5.0);
                    string templateFile = @"\phuctra" + pageNum + ".xlsx";

                    File.Copy(Directory.GetCurrentDirectory() + templateFile, fileName, true);
                    workbook = excelApplication.Workbooks.Open(fileName);
                    worksheet = workbook.Worksheets[1];
                    int[] rows = { 2, 45 };
                    for (int i = 0; i < pageNum; i++)
                    {
                        worksheet.get_Range("A" + rows[i]).Value = worksheet.get_Range("A" + rows[i]).Value + " " + household.Value.MainMember.Name;
                        worksheet.get_Range("G" + rows[i]).Value = worksheet.get_Range("G" + rows[i]).Value + " " + household.Key;
                        worksheet.get_Range("R" + rows[i]).Value = worksheet.get_Range("R" + rows[i]).Value + " " + household.Value.NumRegistered + string.Format(" phiếu (thiếu {0})", household.Value.NumMembers - household.Value.NumRegistered);
                        worksheet.get_Range("A" + (rows[i] + 1)).Value = worksheet.get_Range("A" + (rows[i] + 1)).Value + " " + addressTextbox.Text;
                    }

                    List<Person> members = new List<Person>();

                    if (household.Value.MainMember.IsRegistered)
                    {
                        members.Add(household.Value.MainMember);
                    }

                    IEnumerable<Person> registered = null;
                    IEnumerable<Person> notRegistered = null;
                    if (household.Value.OtherMembers != null)
                    {
                        registered = household.Value.OtherMembers.Where(p => p.IsRegistered);
                        notRegistered = household.Value.OtherMembers.Where(p => !p.IsRegistered);
                    }

                    if (registered != null)
                    {
                        members.AddRange(registered);
                    }
                    if (!household.Value.MainMember.IsRegistered)
                    {
                        members.Add(household.Value.MainMember);
                    }
                    if (notRegistered != null)
                    {
                        members.AddRange(notRegistered);
                    }

                    int[] nameRows = { 5, 48 };
                    string[] nameCols = { "C", "H", "M", "R", "W" };

                    for (int i = 0; i < members.Count; i++)
                    {
                        int r = i / 5;
                        int c = i % 5;
                        string rName = nameCols[c].ToString() + nameRows[r].ToString();
                        worksheet.get_Range(rName).Value = members[i].Name;
                    }

                    string[,] dMarks = { { "D7:E16", "D18:E19", "D21:E22", "D24:E25", "D27:E28", "D30:E32", "D34:E35" },
                                           { "I7:J16", "I18:J19", "I21:J22", "I24:J25", "I27:J28", "I30:J32", "I34:J35"},
                                            { "N7:O16", "N18:O19", "N21:O22", "N24:O25", "N27:O28", "N30:O32", "N34:O35"},
                                            { "S7:T16", "S18:T19", "S21:T22", "S24:T25", "S27:T28", "S30:T32", "S34:T35"},
                                            { "X7:Y16", "X18:Y19", "X21:Y22", "X24:Y25", "X27:Y28", "X30:Y32", "X34:Y35"},
                                            { "D50:E59", "D61:E62", "D64:E65", "D67:E68", "D70:E71", "D73:E75", "D77:E78" },
                                           { "I50:J59", "I61:J62", "I64:J65", "I67:J68", "I70:J71", "I73:J75", "I77:J78"},
                                            { "N50:O59", "N61:O62", "N64:J65", "N67:O68", "N70:O71", "N73:O75", "N77:O78"},
                                            { "S50:T59", "S61:T62", "S64:T65", "S67:T68", "S70:T71", "S73:T75", "S77:T78"},
                                            { "X50:Y59", "X61:Y62", "X64:Y65", "X67:Y68", "X70:Y71", "X73:Y75", "X77:Y78"}};

                    for (int i = 0; i < members.Count; i++)
                    {
                        if (members[i].IsRegistered)
                        {
                            for (int j = 0; j < dMarks.GetLength(1); j++)
                            {
                                worksheet.get_Range(dMarks[i, j]).Value = "Đ";
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    workbook.Save();
                    workbook.Close();
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                excelApplication.Quit();
                Marshal.ReleaseComObject(excelApplication);
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderTextbox.Text = folderDialog.SelectedPath;
            }
        }

        private void load()
        {
            string filePath = fileTextBox.Text;
            if (filePath == null)
            {
                MessageBox.Show("Chọn file");
                return;
            }
            else
            {
                Excel.Application excelApplication = new Excel.Application();
                Excel.Workbook workbook = excelApplication.Workbooks.Open(filePath);
                Excel.Worksheet worksheet = workbook.Worksheets[1];
                Excel.Range range = worksheet.UsedRange;

                object[,] data = (object[,])range.Value2;

                workbook.Close();

                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);

                GC.Collect();
                GC.WaitForPendingFinalizers();
                excelApplication.Quit();
                Marshal.ReleaseComObject(excelApplication);

                if (data != null)
                {
                    village = new Dictionary<int, Household>();
                    Household household = null;
                    int numMembers = 0;
                    int numRegistered = 0;
                    for (int i = 2; i <= data.GetLength(0); i++)
                    {
                        string name = data[i, 1] != null ? data[i, 1].ToString() : "";
                        string dateOfBirth = data[i, 2] != null ? data[i, 2].ToString() : "";
                        bool gender = (data[i, 3] != null && data[i, 3].ToString() == "1") ? true : false;
                        string id = (data[i, 4] != null) ? data[i, 4].ToString() : "";
                        bool isMainMember = (data[i, 5] != null && data[i, 5].ToString() == "1") ? true : false;
                        int householdId = (data[i, 6] != null) ? int.Parse(data[i, 6].ToString()) : -1;
                        bool isRegistered = (data[i, 7] != null && data[i, 7].ToString() == "1") ? false : true;

                        Person person = new Person() { Name = name, DateOfBirth = dateOfBirth, Gender = gender, IdNumber = id, IsRegistered = isRegistered };
                        
                        if (isMainMember)
                        {
                            if (household != null)
                            {
                                household.NumMembers = numMembers;
                                household.NumRegistered = numRegistered;
                            }
                            household = new Household();
                            household.HouseholdId = householdId;
                            household.MainMember = person;
                            village.Add(householdId, household);
                            numMembers = 1;
                            numRegistered = isRegistered ? 1 : 0;
                        }
                        else
                        {
                            if (household.OtherMembers == null)
                            {
                                household.OtherMembers = new List<Person>();
                            }
                            household.OtherMembers.Add(person);
                            numMembers++;
                            if (isRegistered)
                            {
                                numRegistered++;
                            }
                        }
                    }
                    household.NumMembers = numMembers;
                    household.NumRegistered = numRegistered;
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                checkTextbox.Text = fileDialog.FileName;
            }
        }

        private void DC02FolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                DC02Textbox.Text = folderDialog.SelectedPath;
            }
        }

        private void DC02Button_Click(object sender, EventArgs e)
        {
            string[,] checks = { { "C7:E19", "C21:E35"}, { "H7:J19", "H21:J35"}, { "M7:O19", "M21:O35" }, { "R7:T19", "R21:T35" }, { "W7:Y19", "W21:Y35" },
                                    { "C50:E62", "C64:E78"}, { "H50:J62", "H64:J78"}, { "M50:O62", "M64:O78" }, { "R50:T62", "R64:T78" }, { "W50:Y62", "W64:Y78" }};
            string[] nameLocations = { "C5", "H5", "M5", "R5", "W5", "C48", "H48", "M48", "R48", "W48" };
            if (checkTextbox.Text == null || checkTextbox.Text == "")
            {
                MessageBox.Show("Chọn file");
                return;
            }
            if (DC02Textbox.Text == null || DC02Textbox.Text == "")
            {
                MessageBox.Show("Chọn thư mục");
                return;
            }
            string checkFileName = checkTextbox.Text;
            string dc02FolderName = DC02Textbox.Text;

            string fileName = Path.GetFileName(checkFileName);
            string[] arr = fileName.Split(' ');
            int householdId = int.Parse(arr[0]);

            Household household = village[householdId];
            List<Person> members = new List<Person>();
            members.Add(household.MainMember);
            if (household.OtherMembers != null)
            {
                members.AddRange(household.OtherMembers);
            }

            Excel.Application excelApplication = new Excel.Application(); ;
            Excel.Workbook workbook = excelApplication.Workbooks.Open(checkFileName);
            Excel.Worksheet worksheet = worksheet = workbook.Worksheets[1];

            List<string> corrections;

            Excel.Range titles1 = worksheet.get_Range("B7:B19");
            Excel.Range titles2 = worksheet.get_Range("B21:B35");
            string address = worksheet.get_Range("A3").Value.ToString();
            address = address.Split(':')[1].Trim();

            List<DC02> dc02s = new List<DC02>();

            for (int i = 0; i < household.NumRegistered; i++)
            {
                Excel.Range range1 = worksheet.get_Range(checks[i, 0]);
                Excel.Range range2 = worksheet.get_Range(checks[i, 1]);
                object[,] data1 = (object[,]) range1.Value2;
                object[,] data2 = (object[,]) range2.Value2;

                corrections = new List<string>();
                for (int j = 1; j <= data1.GetLength(0); j++)
                {
                    for (int k = 1; k <= data1.GetLength(1); k++)
                    {
                        string d1 = data1[j, k] != null ? data1[j, k].ToString() : "x";
                        if (d1.ToUpper() == "T" || d1.ToUpper() == "S")
                        {
                            string action = d1.ToUpper() == "T" ? "Thêm" : "Sửa";
                            string newValue = range1.Cells[j, k].Comment != null ? range1.Cells[j, k].Comment.Text() : "";
                            string correction = string.Format("{0} {1} thành: {2}", action, titles1.Cells[j, 1].Value.ToString(), newValue);
                            corrections.Add(correction);
                            break;
                        }
                    }
                }

                for (int j = 1; j <= data2.GetLength(0); j++)
                {
                    for (int k = 1; k <= data2.GetLength(1); k++)
                    {
                        string d2 = data2[j, k] != null ? data2[j, k].ToString() : "x";
                        if (d2.ToUpper() == "T" || d2.ToUpper() == "S")
                        {
                            string action = d2.ToUpper() == "T" ? "Thêm" : "Sửa";
                            string newValue = range2.Cells[j, k].Comment != null ? range2.Cells[j, k].Comment.Text() : "";
                            string correction = string.Format("{0} {1} thành: {2}", action, titles2.Cells[j, 1].Value.ToString(), newValue);
                            corrections.Add(correction);
                            break;
                        }
                    }
                }

                if (corrections.Count > 0)
                {
                    string name = worksheet.get_Range(nameLocations[i]).Value.ToString();
                    string attachment = worksheet.get_Range(nameLocations[i]).Comment != null ? worksheet.get_Range(nameLocations[i]).Comment.Text() : "";
                    var person = members.Where(p => p.Name == name).Single();
                    dc02s.Add(new DC02() { Member = person, Corrections = corrections, Attachment = attachment });
                }
            }

            workbook.Close();
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            excelApplication.Quit();
            Marshal.ReleaseComObject(excelApplication);

            if (dc02s.Count > 0)
            {
                string templateFile = Directory.GetCurrentDirectory() + @"\DC02-" + dc02s.Count + ".docx";
                string dc02File = DC02Textbox.Text + @"\" + string.Format("DC02 {0} {1}.docx", household.HouseholdId, household.MainMember.Name);

                File.Copy(templateFile, dc02File, true);

                Word.Application wordApplication = new Word.Application();
                Word.Document document = wordApplication.Documents.Open(dc02File);

                for (int i = 0; i < dc02s.Count; i++)
                {
                    string rName = dc02s[i].Member.Name != null ? dc02s[i].Member.Name : "";
                    string rDOB = dc02s[i].Member.DateOfBirth != null ? dc02s[i].Member.DateOfBirth : "";
                    string rGender = dc02s[i].Member.Gender ? "Nam" : "Nữ";
                    string rId = dc02s[i].Member.IdNumber != null ? dc02s[i].Member.IdNumber : "";
                    string correction = "";
                    foreach (string str in dc02s[i].Corrections)
                    {
                        correction += " - " + str + "\x0B";
                    }

                    FindAndReplace(wordApplication, string.Format("<name{0}>", i + 1), rName);
                    FindAndReplace(wordApplication, string.Format("<dob{0}>", i + 1), rDOB);
                    FindAndReplace(wordApplication, string.Format("<gender{0}>", i + 1), rGender);
                    FindAndReplace(wordApplication, string.Format("<id{0}>", i + 1), rId);
                    FindAndReplace(wordApplication, string.Format("<address{0}>", i + 1), address);
                    
                    FindAndReplace(wordApplication, string.Format("<update{0}>", i + 1), correction);
                    FindAndReplace(wordApplication, string.Format("<attachments{0}>", i + 1), dc02s[i].Attachment);
                }

                document.Save();
                Marshal.ReleaseComObject(document);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                wordApplication.Quit();
                Marshal.ReleaseComObject(wordApplication);
            }     
        }

        private void FindAndReplace(Word.Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
    }  
}
