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
            this.loadButton = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(24, 125);
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
            this.folderTextbox.Location = new System.Drawing.Point(75, 51);
            this.folderTextbox.Name = "folderTextbox";
            this.folderTextbox.ReadOnly = true;
            this.folderTextbox.Size = new System.Drawing.Size(201, 20);
            this.folderTextbox.TabIndex = 0;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(21, 54);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(49, 13);
            this.folderLabel.TabIndex = 1;
            this.folderLabel.Text = "Thư mục";
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(301, 49);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(92, 23);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "Chọn thư mục";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(24, 77);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(97, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Tải danh sách";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 295);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.folderTextbox);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileTextBox);
            this.Name = "Form1";
            this.Text = "896 Tool";
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
        private System.Windows.Forms.Button loadButton;
    }
}

