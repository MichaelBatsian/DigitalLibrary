using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Godeltech.Mastery.DigitalLibrary.BLL.Infrastructure.IdentityServices
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            var from = "white.orchid.st@gmail.com";
            var pass = "soboleva";

            // адрес и порт smtp-сервера, с которого мы и будем отправлять письмо
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(@from, pass),
                EnableSsl = true
            };

            // создаем письмо: message.Destination - адрес получателя
            var mail = new MailMessage(from, message.Destination)
            {
                Subject = message.Subject,
                Body = message.Body,
                IsBodyHtml = true
            };

            return client.SendMailAsync(mail);
        }
    }
}
