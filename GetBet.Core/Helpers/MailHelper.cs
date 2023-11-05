using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Core.Helpers
{
    public static class MailHelper
    {
        /// <summary>
        /// Mail atar.
        /// </summary>
        /// <param name="mailToList"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public static void SendMail(List<string> mailToList,string subject,string body)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();

            foreach (var mailTo in mailToList)
            {
                mail.To.Add(mailTo);
            }

            mail.From = new MailAddress("oguzhanyklmz27@gmail.com", "Oguzhan", System.Text.Encoding.UTF8);
            mail.Subject = subject;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = body;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("oguzhanyklmz27@gmail.com", "dxyx xvqp lwts cvgx");//dxyx xvqp lwts cvgx-ienrmlcfghxujkdq
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;

                string errorMessage = string.Empty;

                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();

                    ex2 = ex2.InnerException;
                }
            }
        }
    }
}
