using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Haberler.Mail
{
    public class SendMail
    {
        public static void Send(string to, string subject, string body)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("newsayvansaray@gmail.com", "ŞifreŞifreŞifre");

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("newsayvansaray@gmail.com", "Ayvansaray Haber");

            mail.To.Add(to);
            

            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;


            sc.Send(mail);
        }

        public static void Send(List<string> to, string subject, string body)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("newsayvansaray@gmail.com", "ŞifreŞifreŞifre");

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("newsayvansaray@gmail.com", "Ayvansaray Haber");

            foreach (var item in to)
            {
                mail.To.Add(item);
            }

            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;


            sc.Send(mail);
        }
    }
}
