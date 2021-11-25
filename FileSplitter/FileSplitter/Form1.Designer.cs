namespace FileSplitter
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.chkFileSize = new System.Windows.Forms.CheckBox();
            this.chkDelimeter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Split";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(599, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Source";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Enabled = false;
            this.txtSourcePath.Location = new System.Drawing.Point(126, 12);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(453, 22);
            this.txtSourcePath.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "File Destination";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(126, 41);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(453, 22);
            this.txtDestination.TabIndex = 10;
            this.txtDestination.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFileSize
            // 
            this.txtFileSize.Enabled = false;
            this.txtFileSize.Location = new System.Drawing.Point(126, 69);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(53, 22);
            this.txtFileSize.TabIndex = 13;
            this.txtFileSize.Text = "20";
            this.txtFileSize.TextChanged += new System.EventHandler(this.txtFileSize_TextChanged);
            this.txtFileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileSize_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "File Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Delimeter";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Enabled = false;
            this.txtDelimiter.Location = new System.Drawing.Point(126, 97);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(53, 22);
            this.txtDelimiter.TabIndex = 15;
            this.txtDelimiter.Text = "GO";
            // 
            // chkFileSize
            // 
            this.chkFileSize.AutoSize = true;
            this.chkFileSize.Checked = true;
            this.chkFileSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileSize.Location = new System.Drawing.Point(185, 74);
            this.chkFileSize.Name = "chkFileSize";
            this.chkFileSize.Size = new System.Drawing.Size(18, 17);
            this.chkFileSize.TabIndex = 17;
            this.chkFileSize.UseVisualStyleBackColor = true;
            this.chkFileSize.CheckedChanged += new System.EventHandler(this.chkFileSize_CheckedChanged);
            // 
            // chkDelimeter
            // 
            this.chkDelimeter.AutoSize = true;
            this.chkDelimeter.Checked = true;
            this.chkDelimeter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelimeter.Location = new System.Drawing.Point(185, 102);
            this.chkDelimeter.Name = "chkDelimeter";
            this.chkDelimeter.Size = new System.Drawing.Size(18, 17);
            this.chkDelimeter.TabIndex = 18;
            this.chkDelimeter.UseVisualStyleBackColor = true;
            this.chkDelimeter.CheckedChanged += new System.EventHandler(this.chkDelimeter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 475);
            this.Controls.Add(this.chkDelimeter);
            this.Controls.Add(this.chkFileSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDelimiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Spit File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.CheckBox chkFileSize;
        private System.Windows.Forms.CheckBox chkDelimeter;
    }
}

