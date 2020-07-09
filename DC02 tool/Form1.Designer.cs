namespace DC02_tool
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
            this.label6 = new System.Windows.Forms.Label();
            this.fileTextbox = new System.Windows.Forms.TextBox();
            this.browseFileButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.browseExcelButton = new System.Windows.Forms.Button();
            this.excelTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toDocButton = new System.Windows.Forms.Button();
            this.householdIdTextbox = new System.Windows.Forms.TextBox();
            this.attachmentRichTextbox = new System.Windows.Forms.RichTextBox();
            this.updateRichTextbox = new System.Windows.Forms.RichTextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleCheckbox = new System.Windows.Forms.RadioButton();
            this.dobDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.exportButton = new System.Windows.Forms.Button();
            this.addTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chọn file";
            // 
            // fileTextbox
            // 
            this.fileTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileTextbox.Location = new System.Drawing.Point(82, 24);
            this.fileTextbox.Name = "fileTextbox";
            this.fileTextbox.ReadOnly = true;
            this.fileTextbox.Size = new System.Drawing.Size(272, 20);
            this.fileTextbox.TabIndex = 16;
            // 
            // browseFileButton
            // 
            this.browseFileButton.Location = new System.Drawing.Point(367, 22);
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(75, 23);
            this.browseFileButton.TabIndex = 17;
            this.browseFileButton.Text = "Chọn file";
            this.browseFileButton.UseVisualStyleBackColor = true;
            this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addTextbox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.exportButton);
            this.tabPage2.Controls.Add(this.browseExcelButton);
            this.tabPage2.Controls.Add(this.excelTextbox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập từ file excel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // browseExcelButton
            // 
            this.browseExcelButton.Location = new System.Drawing.Point(336, 17);
            this.browseExcelButton.Name = "browseExcelButton";
            this.browseExcelButton.Size = new System.Drawing.Size(75, 23);
            this.browseExcelButton.TabIndex = 20;
            this.browseExcelButton.Text = "Chọn file";
            this.browseExcelButton.UseVisualStyleBackColor = true;
            this.browseExcelButton.Click += new System.EventHandler(this.browseExcelButton_Click);
            // 
            // excelTextbox
            // 
            this.excelTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.excelTextbox.Location = new System.Drawing.Point(65, 19);
            this.excelTextbox.Name = "excelTextbox";
            this.excelTextbox.ReadOnly = true;
            this.excelTextbox.Size = new System.Drawing.Size(256, 20);
            this.excelTextbox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "File excel";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toDocButton);
            this.tabPage1.Controls.Add(this.householdIdTextbox);
            this.tabPage1.Controls.Add(this.attachmentRichTextbox);
            this.tabPage1.Controls.Add(this.updateRichTextbox);
            this.tabPage1.Controls.Add(this.addressTextbox);
            this.tabPage1.Controls.Add(this.idTextbox);
            this.tabPage1.Controls.Add(this.nameTextbox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dobDatetimePicker);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập thủ công";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toDocButton
            // 
            this.toDocButton.Location = new System.Drawing.Point(165, 457);
            this.toDocButton.Name = "toDocButton";
            this.toDocButton.Size = new System.Drawing.Size(75, 23);
            this.toDocButton.TabIndex = 28;
            this.toDocButton.Text = "Lưu ra file";
            this.toDocButton.UseVisualStyleBackColor = true;
            // 
            // householdIdTextbox
            // 
            this.householdIdTextbox.Location = new System.Drawing.Point(353, 16);
            this.householdIdTextbox.Name = "householdIdTextbox";
            this.householdIdTextbox.Size = new System.Drawing.Size(60, 20);
            this.householdIdTextbox.TabIndex = 27;
            // 
            // attachmentRichTextbox
            // 
            this.attachmentRichTextbox.Location = new System.Drawing.Point(10, 376);
            this.attachmentRichTextbox.Name = "attachmentRichTextbox";
            this.attachmentRichTextbox.Size = new System.Drawing.Size(403, 72);
            this.attachmentRichTextbox.TabIndex = 25;
            this.attachmentRichTextbox.Text = "";
            // 
            // updateRichTextbox
            // 
            this.updateRichTextbox.Location = new System.Drawing.Point(10, 285);
            this.updateRichTextbox.Name = "updateRichTextbox";
            this.updateRichTextbox.Size = new System.Drawing.Size(403, 73);
            this.updateRichTextbox.TabIndex = 24;
            this.updateRichTextbox.Text = "";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(71, 221);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(342, 20);
            this.addressTextbox.TabIndex = 23;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(71, 188);
            this.idTextbox.MaxLength = 12;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(342, 20);
            this.idTextbox.TabIndex = 21;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(71, 16);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(220, 20);
            this.nameTextbox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Số HSHK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ĐDCN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.maleCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(10, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 74);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(19, 42);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(39, 17);
            this.femaleRadioButton.TabIndex = 1;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Nữ";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleCheckbox
            // 
            this.maleCheckbox.AutoSize = true;
            this.maleCheckbox.Location = new System.Drawing.Point(19, 19);
            this.maleCheckbox.Name = "maleCheckbox";
            this.maleCheckbox.Size = new System.Drawing.Size(47, 17);
            this.maleCheckbox.TabIndex = 0;
            this.maleCheckbox.TabStop = true;
            this.maleCheckbox.Text = "Nam";
            this.maleCheckbox.UseVisualStyleBackColor = true;
            // 
            // dobDatetimePicker
            // 
            this.dobDatetimePicker.CustomFormat = "dd/MM/yyyy";
            this.dobDatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDatetimePicker.Location = new System.Drawing.Point(71, 59);
            this.dobDatetimePicker.Name = "dobDatetimePicker";
            this.dobDatetimePicker.Size = new System.Drawing.Size(220, 20);
            this.dobDatetimePicker.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 523);
            this.tabControl.TabIndex = 18;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(163, 94);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 21;
            this.exportButton.Text = "Xuất ra file";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // addTextbox
            // 
            this.addTextbox.Location = new System.Drawing.Point(66, 54);
            this.addTextbox.Name = "addTextbox";
            this.addTextbox.Size = new System.Drawing.Size(255, 20);
            this.addTextbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Địa chỉ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 595);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.browseFileButton);
            this.Controls.Add(this.fileTextbox);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileTextbox;
        private System.Windows.Forms.Button browseFileButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button toDocButton;
        private System.Windows.Forms.TextBox householdIdTextbox;
        private System.Windows.Forms.RichTextBox attachmentRichTextbox;
        private System.Windows.Forms.RichTextBox updateRichTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleCheckbox;
        private System.Windows.Forms.DateTimePicker dobDatetimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button browseExcelButton;
        private System.Windows.Forms.TextBox excelTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox addTextbox;
        private System.Windows.Forms.Label label8;
    }
}

