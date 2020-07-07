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
using Word = Microsoft.Office.Interop.Word;

namespace DC02_tool
{
    public partial class Form1 : Form
    {
        private string templateFile = Directory.GetCurrentDirectory() + @"\dc02.docx";
        private string filePath;
        //private Word.Application wordApplication;

        public Form1()
        {
            InitializeComponent();
        }

        private void householdIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void toDocButton_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string householdId = householdIdTextbox.Text;
            string dob = dobDatetimePicker.Value.ToString("ddMMyyyy");
            bool gender = maleCheckbox.Checked ? true : false;
            string id = idTextbox.Text;
            string address = addressTextbox.Text;
            string update = updateRichTextbox.Text;
            string attachment = attachmentRichTextbox.Text;

            if (filePath == "")
            {
                MessageBox.Show("Chọn file");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Điền tên");
                return;
            }

            string tempFile = Directory.GetCurrentDirectory() + @"\temp.docx";
            File.Copy(templateFile, tempFile);
            Word.Application wordApplication = new Word.Application();
            Word.Document tempDoc = wordApplication.Documents.Open(tempFile);

            FindAndReplace(tempDoc, "{name}", name);

            char[] dobArr = dob.ToCharArray();
            for (int i = 0; i < dobArr.Length; i++)
            {
                FindAndReplace(tempDoc, "{d" + i + "}", dobArr[i].ToString());
            }

            string checkLoc = gender ? "0" : "1";
            string uncheckLoc = !gender ? "0" : "1";
            FindAndReplace(tempDoc, "{s" + checkLoc + "}", "X");
            FindAndReplace(tempDoc, "{s" + uncheckLoc + "}", "");

            char[] idArr = id.ToCharArray();
            for (int i = 0; i < idArr.Length; i++)
            {
                FindAndReplace(tempDoc, "{i" + i + "}", idArr[i].ToString());
            }

            FindAndReplace(tempDoc, "{address}", address);
            FindAndReplace(tempDoc, "{update}", update);
            FindAndReplace(tempDoc, "{attachment}", attachment);

            tempDoc.Save();
            Marshal.ReleaseComObject(tempDoc);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            wordApplication.Quit();
            Marshal.ReleaseComObject(wordApplication);
        }

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "doc file (*.doc)|*.doc|docx file (*.docx)|*.docx";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileTextbox.Text = fileDialog.FileName;
                filePath = fileTextbox.Text;

                //wordApplication = new Word.Application();
                //Word.Document generatedDocument = wordApplication.Documents.Open(filePath);
                //Word.Document templateDocument = wordApplication.Documents.Open(templateFile);
            }
        }

        private void FindAndReplace(Word.Document doc, object findText, object replaceWithText)
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
            

            var range = doc.Range();

            
            range.Find.Execute(FindText: findText, ReplaceWith: replaceWithText, Replace: Word.WdReplace.wdReplaceAll);

            var shapes = doc.Shapes;
            

            foreach (Word.Shape shape in shapes)
            {
                var initialText = shape.TextFrame.TextRange.Text;
                var resultingText = initialText.Replace(findText.ToString(), replaceWithText.ToString());
                shape.TextFrame.TextRange.Text = resultingText;

            }
        }
    }
}
