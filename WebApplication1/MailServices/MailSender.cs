using System.Net;
using System.Net.Mail;
namespace WebApplication1.MailServices;
public class MailSender
{

    public static bool SendMail(string emailAddress, string subject, string body)
    {
        var res = false;

        MailMessage mail = new MailMessage();

        SmtpClient smtp = new SmtpClient("mail.example.org");

        if (!res)
        {
            mail.From = new MailAddress("info@example.org", "title");

            mail.To.Add(emailAddress);

            mail.Subject = subject;

            mail.Body = body;

            mail.IsBodyHtml = true;

            smtp.Port = 587;

            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("info@example.org", "password");

            smtp.Send(mail);

            res = true;
        }

        return res;
    }

}