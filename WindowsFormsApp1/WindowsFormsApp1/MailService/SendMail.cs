using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendMailService.MailService
{
    class SendMail
    {
        private static bool isSend = true;
        public void sendMail(string pathName, string body, string subject, MailConfig mailConifg)
        {
            if (isSend)
            {
                SmtpClient smtp = mailConifg.buildSmtpClient();
                MailMessage message = mailConifg.buildMailMessageWithImage(pathName, body, subject);
                try
                {
                    smtp.Send(message);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public async void SendMailAsync(SmtpClient smtp, MailMessage message)
        {
            await smtp.SendMailAsync(message);
        }

    }
}
