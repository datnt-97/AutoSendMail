using System;
using System.Net.Mail;
using System.Net.Sockets;

namespace AutoSendMailService.MailService
{
    class MailConfig
    {
        private static string mailFrom = "";
        private static string mailTo = "";
        private static string mailCc = "";
        private static string mailBcc = "";
        private static string pw = "";
        private static string smtpClient = "smtp.gmail.com";
        private static string pathRootImage = "";
        private static int port = 587;

        public MailConfig(string _mailFrom, string _mailTo,
            string _pw, string _smtpClient, string _pathRootImage, int _port,
            string _mailCc, string _mailBcc)
        {
            mailFrom = _mailFrom;
            mailTo = _mailTo;
            pw = _pw;
            smtpClient = _smtpClient;
            pathRootImage = _pathRootImage;
            port = _port;
            mailCc = _mailCc;
            mailBcc = _mailBcc;
        }

        public SmtpClient buildSmtpClient()
        {
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential(mailFrom, pw);
            SmtpClient smtp = new SmtpClient(smtpClient, port);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = cred;

            return smtp;
        }
       

        public MailMessage buildMailMessageWithImage(string pathName, string body, string subject)
        {
            //create an instance of new mail message
            MailMessage mail = new MailMessage();

            //set the HTML format to true
            mail.IsBodyHtml = true;

            //create Alrternative HTML view
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

            if (pathName != "")
            {
                //Add Image
                LinkedResource theEmailImage = new LinkedResource(pathRootImage + "\\" + pathName);
                theEmailImage.ContentId = "myImageID";

                //Add the Image to the Alternate view
                htmlView.LinkedResources.Add(theEmailImage);
            }
           

            //Add view to the Email Message
            mail.AlternateViews.Add(htmlView);

            //set the "from email" address and specify a friendly 'from' name
            mail.From = new MailAddress(mailFrom);


            //set the "to" email address
            string[] arrMailTo = mailTo.Split(',');
            for (int i = 0; i < mailTo.Length; i++)
            {
                mail.To.Add(mailTo);
            }
            if (mailCc != "")
            {
                string[] arrMailCc = mailCc.Split(',');
                for (int i = 0; i < arrMailCc.Length; i++)
                {
                    mail.CC.Add(mailCc);
                }

            }
            if (mailBcc != "")
            {
                string[] arrMailBcc = mailBcc.Split(',');
                for (int i = 0; i < arrMailBcc.Length; i++)
                {
                    mail.Bcc.Add(mailBcc);
                }
            }

            //set the Email subject
            mail.Subject = subject;
            return mail;
        }
    }
}
