using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Assignment.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("893590048@qq.com", "Yu Wu");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

        public void SendWithAttachment(String toEmail, String subject, String contents, String filePath, String fileName)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("893590048@qq.com", "Yu Wu");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            var attachment = File.ReadAllBytes(filePath);
            msg.AddAttachment(fileName, Convert.ToBase64String(attachment));

            var response = client.SendEmailAsync(msg);
        }

    }
}