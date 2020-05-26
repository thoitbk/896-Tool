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
    }  
}
