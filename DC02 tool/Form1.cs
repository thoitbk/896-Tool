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
        private const string TEMPLATE_FILE = @"dc02.docx";
        private string templateFile = Directory.GetCurrentDirectory() + @"\" + TEMPLATE_FILE;
        private string genFileName;
        private string genFilePath;
        private Word.Application wordApplication;
        private Word.Document templateDoc;
        private Word.Document generatedDoc;

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

            if (genFilePath == null || genFilePath == "")
            {
                MessageBox.Show("Chọn file");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Điền tên");
                return;
            }

            init();

            FindAndReplace(templateDoc, "{name}", name.ToUpper());

            char[] dobArr = dob.ToCharArray();
            for (int i = 0; i < dobArr.Length; i++)
            {
                FindAndReplace(templateDoc, "{d" + i + "}", dobArr[i].ToString());
            }

            string checkLoc = gender ? "0" : "1";
            string uncheckLoc = !gender ? "0" : "1";
            FindAndReplace(templateDoc, "{s" + checkLoc + "}", "X");
            FindAndReplace(templateDoc, "{s" + uncheckLoc + "}", "");

            char[] idArr = id.ToCharArray();
            for (int i = 0; i < 12; i++)
            {
                if (i < idArr.Length)
                {
                    FindAndReplace(templateDoc, "{i" + i + "}", idArr[i].ToString());
                }
                else
                {
                    FindAndReplace(templateDoc, "{i" + i + "}", "");
                }
            }

            FindAndReplace(templateDoc, "{address}", address);
            FindAndReplace(templateDoc, "{update}", update);
            FindAndReplace(templateDoc, "{attachment}", attachment);

            Word.Range source = templateDoc.Content;
            source.Copy();

            generatedDoc.Characters.Last.Select();
            wordApplication.Selection.Collapse(); 
            Object objUnit = Word.WdUnits.wdStory;
            wordApplication.Selection.EndKey(ref objUnit, null);
            wordApplication.Selection.PasteAndFormat(Word.WdRecoveryType.wdPasteDefault);
            generatedDoc.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

            generatedDoc.Save();
            
            templateDoc.Close(SaveChanges: Word.WdSaveOptions.wdDoNotSaveChanges);

            nameTextbox.Text = "";
            householdIdTextbox.Text = "";
            dobDatetimePicker.Value = DateTime.Now;
            maleCheckbox.Checked = true;
            idTextbox.Text = "";
            updateRichTextbox.Text = "";
            attachmentRichTextbox.Text = "";
        }

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "docx file (*.docx)|*.docx|doc file (*.doc)|*.doc";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileTextbox.Text = fileDialog.FileName;
                genFilePath = fileTextbox.Text;
                genFileName = Path.GetFileName(genFilePath);

                init();
            }
        }

        private void init()
        {
            if (wordApplication == null) wordApplication = new Word.Application();
            if (!IsDocOpen(genFileName)) generatedDoc = wordApplication.Documents.Open(genFilePath);
            if (!IsDocOpen(TEMPLATE_FILE)) templateDoc = wordApplication.Documents.Open(templateFile);
        }

        private void FindAndReplace(Word.Document doc, object findText, object replaceWithText)
        {
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (wordApplication != null)
            {
                generatedDoc.Close();
                Marshal.ReleaseComObject(templateDoc);
                Marshal.ReleaseComObject(generatedDoc);
                GC.Collect();
                GC.WaitForPendingFinalizers();

                wordApplication.Quit();
                Marshal.ReleaseComObject(wordApplication);
            }
        }

        private bool IsDocOpen(string name)
        {
            foreach (Word.Document d in wordApplication.Documents)
            {
                if (d.Name == name) return true;
            }
            return false;
        }
    }
}
