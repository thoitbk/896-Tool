using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderTextbox.Text == null || folderTextbox.Text == "")
            {
                MessageBox.Show("Chon thu muc");
            }
            else
            {
                string folderPath = folderTextbox.Text;
                Excel.Application excelApplication;
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
                    excelApplication = new Excel.Application();
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

                    worksheet.get_Range("D8:F11").Value = "D";

                    workbook.Save();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(worksheet);
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                    excelApplication.Quit();
                    Marshal.ReleaseComObject(excelApplication);
                }
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

        private void loadButton_Click(object sender, EventArgs e)
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

                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(worksheet);
                workbook.Close();
                Marshal.ReleaseComObject(workbook);
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
    }  
}
