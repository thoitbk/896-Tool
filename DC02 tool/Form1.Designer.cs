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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dobDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleCheckbox = new System.Windows.Forms.RadioButton();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateRichTextbox = new System.Windows.Forms.RichTextBox();
            this.attachment = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.householdIdTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(79, 39);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(220, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // dobDatetimePicker
            // 
            this.dobDatetimePicker.CustomFormat = "dd/MM/yyyy";
            this.dobDatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobDatetimePicker.Location = new System.Drawing.Point(79, 82);
            this.dobDatetimePicker.Name = "dobDatetimePicker";
            this.dobDatetimePicker.Size = new System.Drawing.Size(220, 20);
            this.dobDatetimePicker.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.maleCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(18, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 74);
            this.groupBox1.TabIndex = 5;
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
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(79, 211);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(320, 20);
            this.idTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐDCN";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(79, 244);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(320, 20);
            this.addressTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // updateRichTextbox
            // 
            this.updateRichTextbox.Location = new System.Drawing.Point(18, 308);
            this.updateRichTextbox.Name = "updateRichTextbox";
            this.updateRichTextbox.Size = new System.Drawing.Size(381, 73);
            this.updateRichTextbox.TabIndex = 10;
            this.updateRichTextbox.Text = "";
            // 
            // attachment
            // 
            this.attachment.Location = new System.Drawing.Point(18, 399);
            this.attachment.Name = "attachment";
            this.attachment.Size = new System.Drawing.Size(381, 72);
            this.attachment.TabIndex = 11;
            this.attachment.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số HSHK";
            // 
            // householdIdTextbox
            // 
            this.householdIdTextbox.Location = new System.Drawing.Point(361, 39);
            this.householdIdTextbox.Name = "householdIdTextbox";
            this.householdIdTextbox.Size = new System.Drawing.Size(60, 20);
            this.householdIdTextbox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 542);
            this.Controls.Add(this.householdIdTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attachment);
            this.Controls.Add(this.updateRichTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dobDatetimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dobDatetimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleCheckbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox updateRichTextbox;
        private System.Windows.Forms.RichTextBox attachment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox householdIdTextbox;
    }
}

