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
        private string tempFile = Directory.GetCurrentDirectory() + @"\temp.docx";
        private string filePath;
        private Word.Application wordApplication;
        private Word.Document tempDoc;
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

            if (filePath == null || filePath == "")
            {
                MessageBox.Show("Chọn file");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Điền tên");
                return;
            }

            tempDoc = wordApplication.Documents.Open(tempFile);

            FindAndReplace(tempDoc, "{name}", name.ToUpper());

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
            for (int i = 0; i < 12; i++)
            {
                if (i < idArr.Length)
                {
                    FindAndReplace(tempDoc, "{i" + i + "}", idArr[i].ToString());
                }
                else
                {
                    FindAndReplace(tempDoc, "{i" + i + "}", "");
                }
            }

            FindAndReplace(tempDoc, "{address}", address);
            FindAndReplace(tempDoc, "{update}", update);
            FindAndReplace(tempDoc, "{attachment}", attachment);

            Word.Range source = tempDoc.Content;
            source.Copy();

            object what = Word.WdGoToItem.wdGoToLine;
            object which = Word.WdGoToDirection.wdGoToLast;
            generatedDoc.GoTo(ref what, ref which, null, null);
            generatedDoc.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

            wordApplication.Selection.EndKey(Word.WdUnits.wdStory, null);

            //generatedDoc.PasteAndFormat(Word.WdRecoveryType.wdPasteDefault);
            generatedDoc.Content.PasteAndFormat(Word.WdRecoveryType.wdFormatOriginalFormatting);
            generatedDoc.Save();

            tempDoc.Close(SaveChanges: Word.WdSaveOptions.wdDoNotSaveChanges);

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
            fileDialog.Filter = "doc file (*.doc)|*.doc|docx file (*.docx)|*.docx";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileTextbox.Text = fileDialog.FileName;
                filePath = fileTextbox.Text;

                wordApplication = new Word.Application();
                File.Copy(templateFile, tempFile);

                generatedDoc = wordApplication.Documents.Open(filePath);

            }
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
            generatedDoc.Close();
            Marshal.ReleaseComObject(tempDoc);
            Marshal.ReleaseComObject(generatedDoc);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            wordApplication.Quit();
            Marshal.ReleaseComObject(wordApplication);

            File.Delete(tempFile);
        }
    }
}
