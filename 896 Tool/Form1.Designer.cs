namespace _896_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderTextbox = new System.Windows.Forms.TextBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DC02Button = new System.Windows.Forms.Button();
            this.DC02FolderButton = new System.Windows.Forms.Button();
            this.DC02Label = new System.Windows.Forms.Label();
            this.DC02Textbox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.checkLabel = new System.Windows.Forms.Label();
            this.checkTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fileTextBox.Location = new System.Drawing.Point(75, 22);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(201, 20);
            this.fileTextBox.TabIndex = 0;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(21, 25);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(48, 13);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "Chọn file";
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(301, 20);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(92, 23);
            this.fileButton.TabIndex = 2;
            this.fileButton.Text = "Chọn file";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tạo file excel kết quả phúc tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderTextbox
            // 
            this.folderTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.folderTextbox.Location = new System.Drawing.Point(61, 20);
            this.folderTextbox.Name = "folderTextbox";
            this.folderTextbox.ReadOnly = true;
            this.folderTextbox.Size = new System.Drawing.Size(201, 20);
            this.folderTextbox.TabIndex = 0;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(6, 23);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(49, 13);
            this.folderLabel.TabIndex = 1;
            this.folderLabel.Text = "Thư mục";
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(277, 18);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(92, 23);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "Chọn thư mục";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(61, 55);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(201, 20);
            this.addressTextbox.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 180);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.folderButton);
            this.tabPage1.Controls.Add(this.addressTextbox);
            this.tabPage1.Controls.Add(this.folderLabel);
            this.tabPage1.Controls.Add(this.folderTextbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo file excel kết quả kiểm tra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa chỉ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DC02Button);
            this.tabPage2.Controls.Add(this.DC02FolderButton);
            this.tabPage2.Controls.Add(this.DC02Label);
            this.tabPage2.Controls.Add(this.DC02Textbox);
            this.tabPage2.Controls.Add(this.checkButton);
            this.tabPage2.Controls.Add(this.checkLabel);
            this.tabPage2.Controls.Add(this.checkTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 154);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sinh DC02";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DC02Button
            // 
            this.DC02Button.Location = new System.Drawing.Point(145, 110);
            this.DC02Button.Name = "DC02Button";
            this.DC02Button.Size = new System.Drawing.Size(100, 23);
            this.DC02Button.TabIndex = 9;
            this.DC02Button.Text = "Sinh DC02";
            this.DC02Button.UseVisualStyleBackColor = true;
            this.DC02Button.Click += new System.EventHandler(this.DC02Button_Click);
            // 
            // DC02FolderButton
            // 
            this.DC02FolderButton.Location = new System.Drawing.Point(285, 56);
            this.DC02FolderButton.Name = "DC02FolderButton";
            this.DC02FolderButton.Size = new System.Drawing.Size(92, 23);
            this.DC02FolderButton.TabIndex = 8;
            this.DC02FolderButton.Text = "Chọn thư mục";
            this.DC02FolderButton.UseVisualStyleBackColor = true;
            this.DC02FolderButton.Click += new System.EventHandler(this.DC02FolderButton_Click);
            // 
            // DC02Label
            // 
            this.DC02Label.AutoSize = true;
            this.DC02Label.Location = new System.Drawing.Point(4, 61);
            this.DC02Label.Name = "DC02Label";
            this.DC02Label.Size = new System.Drawing.Size(49, 13);
            this.DC02Label.TabIndex = 7;
            this.DC02Label.Text = "Thư mục";
            // 
            // DC02Textbox
            // 
            this.DC02Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.DC02Textbox.Location = new System.Drawing.Point(59, 58);
            this.DC02Textbox.Name = "DC02Textbox";
            this.DC02Textbox.ReadOnly = true;
            this.DC02Textbox.Size = new System.Drawing.Size(201, 20);
            this.DC02Textbox.TabIndex = 6;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(285, 21);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(92, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Chọn file";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(6, 26);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(48, 13);
            this.checkLabel.TabIndex = 4;
            this.checkLabel.Text = "Chọn file";
            // 
            // checkTextbox
            // 
            this.checkTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.checkTextbox.Location = new System.Drawing.Point(59, 23);
            this.checkTextbox.Name = "checkTextbox";
            this.checkTextbox.ReadOnly = true;
            this.checkTextbox.Size = new System.Drawing.Size(201, 20);
            this.checkTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileTextBox);
            this.Name = "Form1";
            this.Text = "896 Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox folderTextbox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.TextBox checkTextbox;
        private System.Windows.Forms.Button DC02FolderButton;
        private System.Windows.Forms.Label DC02Label;
        private System.Windows.Forms.TextBox DC02Textbox;
        private System.Windows.Forms.Button DC02Button;
    }
}

