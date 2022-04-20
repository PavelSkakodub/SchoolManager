using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EF_School_DB_Managment.Controllers
{
    public class EmailSender
    {
        //порт smtp-сервера
        private int Port { get; set; } = 587;

        //отправка сообщения на емейл
        public void SendEmail(string name, string email, string subject, string message)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("alex.rabota.2000@mail.ru", name);
            // кому отправляем
            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to)
            {
                Subject = subject, //тема письма
                Body = message, //текст письма
                IsBodyHtml = true //письмо представляет код html
            };

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", Port)
            {
                // логин и пароль
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("alex.rabota.2000@mail.ru", "0gqCHhWwM1Gn9J3iZ5p9")
            };

            //отправка сообщения
            smtp.Send(m);
        }
    }
}
