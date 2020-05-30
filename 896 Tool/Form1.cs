using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    for (int i = 2; i < data.GetLength(0); i++)
                    {
                        string name = data[i, 1].ToString();
                        DateTime dateOfBirth = DateTime.Now;//DateTime.Parse(data[i, 2].ToString());
                        bool gender = (data[i, 3] != null && data[i, 3].ToString() == "1") ? true : false;
                        string id = (data[i, 4] != null) ? data[i, 4].ToString() : "";
                        bool isMainMember = (data[i, 5] != null && data[i, 5].ToString() == "1") ? true : false;
                        int householdId = (data[i, 6] != null) ? int.Parse(data[i, 6].ToString()) : -1;
                        bool isRegistered = (data[i, 7] != null && data[i, 7].ToString() == "1") ? false : true;

                        Person person = new Person() { Name = name, DateOfBirth = dateOfBirth, Gender = gender, IdNumber = id, IsRegistered = isRegistered };
                        numMembers++;
                        if (isRegistered)
                        {
                            numRegistered++;
                        }
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
                        }
                    }
                }
            }
        }
    }  
}
