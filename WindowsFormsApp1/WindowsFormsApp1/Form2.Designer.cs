namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMailBcc = new System.Windows.Forms.TextBox();
            this.tbMailCc = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.tbMailForm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassMail = new System.Windows.Forms.TextBox();
            this.cmPort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSmtpMail = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.cmSsl = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbUserName);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbPass);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbDBName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbServerName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "UserName";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(104, 101);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(181, 20);
            this.tbUserName.TabIndex = 26;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(104, 206);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Password";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(104, 139);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(181, 20);
            this.tbPass.TabIndex = 27;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Database Name";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(104, 63);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(181, 20);
            this.tbDBName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Server Name";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(104, 27);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(181, 20);
            this.tbServerName.TabIndex = 23;
            this.tbServerName.TextChanged += new System.EventHandler(this.tbServerName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmSsl);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbMailBcc);
            this.tabPage2.Controls.Add(this.tbMailCc);
            this.tabPage2.Controls.Add(this.tbPath);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tbMailTo);
            this.tabPage2.Controls.Add(this.tbMailForm);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbPassMail);
            this.tabPage2.Controls.Add(this.cmPort);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbSmtpMail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Mail Bcc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Mail cc";
            // 
            // tbMailBcc
            // 
            this.tbMailBcc.Location = new System.Drawing.Point(77, 195);
            this.tbMailBcc.Name = "tbMailBcc";
            this.tbMailBcc.Size = new System.Drawing.Size(184, 20);
            this.tbMailBcc.TabIndex = 52;
            // 
            // tbMailCc
            // 
            this.tbMailCc.Location = new System.Drawing.Point(77, 156);
            this.tbMailCc.Name = "tbMailCc";
            this.tbMailCc.Size = new System.Drawing.Size(184, 20);
            this.tbMailCc.TabIndex = 51;
            // 
            // tbPath
            // 
            this.tbPath.AutoSize = true;
            this.tbPath.Location = new System.Drawing.Point(14, 312);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(0, 13);
            this.tbPath.TabIndex = 50;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Folder Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbMailTo
            // 
            this.tbMailTo.Location = new System.Drawing.Point(77, 119);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(184, 20);
            this.tbMailTo.TabIndex = 48;
            // 
            // tbMailForm
            // 
            this.tbMailForm.Location = new System.Drawing.Point(77, 54);
            this.tbMailForm.Name = "tbMailForm";
            this.tbMailForm.Size = new System.Drawing.Size(141, 20);
            this.tbMailForm.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Mail To";
            // 
            // tbPassMail
            // 
            this.tbPassMail.Location = new System.Drawing.Point(77, 87);
            this.tbPassMail.Name = "tbPassMail";
            this.tbPassMail.Size = new System.Drawing.Size(184, 20);
            this.tbPassMail.TabIndex = 45;
            this.tbPassMail.TextChanged += new System.EventHandler(this.tbPassMail_TextChanged);
            // 
            // cmPort
            // 
            this.cmPort.Location = new System.Drawing.Point(265, 18);
            this.cmPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cmPort.Name = "cmPort";
            this.cmPort.Size = new System.Drawing.Size(70, 20);
            this.cmPort.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mail From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "SMTP Mail";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbSmtpMail
            // 
            this.tbSmtpMail.Location = new System.Drawing.Point(77, 18);
            this.tbSmtpMail.Name = "tbSmtpMail";
            this.tbSmtpMail.Size = new System.Drawing.Size(141, 20);
            this.tbSmtpMail.TabIndex = 33;
            this.tbSmtpMail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "SSL";
            // 
            // cmSsl
            // 
            this.cmSsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSsl.FormattingEnabled = true;
            this.cmSsl.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmSsl.Location = new System.Drawing.Point(265, 53);
            this.cmSsl.Name = "cmSsl";
            this.cmSsl.Size = new System.Drawing.Size(68, 21);
            this.cmSsl.TabIndex = 57;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 367);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSmtpMail;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.TextBox tbMailForm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassMail;
        private System.Windows.Forms.NumericUpDown cmPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label tbPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMailBcc;
        private System.Windows.Forms.TextBox tbMailCc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmSsl;
    }
}