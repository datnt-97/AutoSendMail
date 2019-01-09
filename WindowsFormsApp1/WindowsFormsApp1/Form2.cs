using AutoSendBirhDayMail.DBConnection;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(bool value)
        {
            InitializeComponent();
        }

        private void showMess(string mess)
        {
            MessageBox.Show(mess);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {




        }


        private void Form2_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Left = 700;
            this.Top = 200;
            tbServerName.Text = System.Environment.MachineName;
            tbDBName.Text = "";
            tbUserName.Text = "";
            tbPass.Text = "";
            tbServerName.ReadOnly = true;
            cmPort.Value = 587;
            tbSmtpMail.Text = "";
            tbMailForm.Text = "";
            tbMailTo.Text = "";
            tbPassMail.Text = "";

            tabPage1.Text = @"Login";
            tabPage2.Text = @"Setting Email";

        }

        string folderPath = "D:\\image";


        private void btnCancel_Click(object sender, EventArgs e)
        {


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }

        private void tbServerName_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validation()
        {
            if (tbServerName.Text == "")
            {
                showMess("Server name not empy !");
                return false;
            }

            if (tbDBName.Text == "")
            {
                showMess("DB name not empy !");
                return false;
            }
            if (tbUserName.Text == "")
            {
                showMess("User name not empy !");
                return false;
            }
            if (tbPass.Text == "")
            {
                showMess("Password not empy !");
                return false;
            }
            if (tbSmtpMail.Text == "")
            {
                showMess("SmtpMail not empy !");
                return false;
            }
            if (cmPort.Value <= 0)
            {
                showMess("Port not empy !");
                return false;
            }

            if (tbPassMail.Text == "")
            {
                showMess("Password not empy !");
                return false;
            }
            if (tbMailForm.Text == "" || !ValidateEmail(tbMailForm.Text))
            {
                showMess("Mail form not empy and email !");
                return false;
            }
            if (tbMailTo.Text == "" || !ValidateEmail(tbMailTo.Text))
            {
                showMess("Mail to not empy and email !");

                return false;
            }
            if (folderPath == "")
            {
                showMess("Folder to not empy !");
                return false;
            }
            return true;
        }
        private bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (!validation())
            {
                return;
            }
            Form1 form1 = new Form1();
            try
            {
                form1.Show();
                this.Hide();
                //test connect DB
                DBTestConnection dBTestConnection = new DBTestConnection();
                dBTestConnection.TestConnection(tbServerName.Text, tbDBName.Text, tbUserName.Text, tbPass.Text);
                AutoSendMailService.MailService.MailConfig mailConifg =
                 new AutoSendMailService.MailService.MailConfig(
                     tbMailForm.Text,
                     tbMailForm.Text,
                     tbPassMail.Text,
                     tbSmtpMail.Text,
                     folderPath,
                     (int)cmPort.Value,
                     tbMailCc.Text,
                     tbMailBcc.Text);
                new AutoSendMailService.MailService.SendMail()
                    .sendMail("", "Test connect authentication : " + DateTime.Now, "Mail Test Send Birth Day Mail", mailConifg);
            }

            catch (Exception ec)
            {
                showMess(ec.Message);
                this.Show();
                form1.Hide();
            }
           
            //set up 8:00, every 24 hour
             MyScheduler.IntervalInHours(8, 0, 24,
            () =>
             {
                 try
                 {
                     AutoSendMailService.MailService.MailConfig mailConifg1 =
                      new AutoSendMailService.MailService.MailConfig(
                          tbMailForm.Text,
                          tbMailTo.Text,
                          tbPassMail.Text,
                          tbSmtpMail.Text,
                          folderPath,
                          (int)cmPort.Value,
                          tbMailCc.Text,
                          tbMailBcc.Text);
                     AutoSendMailService.WorkWithDatabase database = new AutoSendMailService.WorkWithDatabase(mailConifg1);
                     database.CallDatabase(tbServerName.Text, tbDBName.Text, tbUserName.Text, tbPass.Text);
                 }
                 catch (Exception ec)
                 {
                     showMess(ec.Message);
                     this.Show();
                     form1.Hide();
                 }
             });

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassMail_TextChanged(object sender, EventArgs e)
        {
            tbPassMail.PasswordChar = '*';

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPath.Text = folderDlg.SelectedPath;
                folderPath = folderDlg.SelectedPath + "\\";
                if (tbPath.Text.Length > 70)
                {
                    string str = tbPath.Text;
                    tbPath.Text = str.Substring(0, 10) + "..." + str.Substring(str.Length / 2, (str.Length - str.Length / 2));
                }

                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }

}
