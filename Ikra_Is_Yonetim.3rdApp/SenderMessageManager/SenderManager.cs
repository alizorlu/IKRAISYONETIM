using Ikra_Is_Yonetim._3rdApp.EmailManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim._3rdApp.SenderMessageManager
{
    public interface ISenderManager
    {
        void SendMessage(MessageFormat message);
        
    }
    public class EmailSender : ISenderManager
    {
        private IEmailManager _email;
        public EmailSender(IEmailManager email)
        {
            _email = email;
        }
        public void SendMessage(MessageFormat message)
        {
            DAL.EntityFramework.Tables.Email supportEmail = _email.Get();
            if (supportEmail == null) return;
            MailMessage mail = new MailMessage();
            mail.To.Add(message.Hedef);
            mail.From = new MailAddress(supportEmail.EmailAddres);
            mail.Subject = message.Baslik;
            mail.Body = message.Icerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = supportEmail.Host;
            smtp.Port = int.Parse(supportEmail.Port);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(supportEmail.EmailAddres, supportEmail.Password); // Enter seders User name and password  
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }
    }
    public class SmsSender : ISenderManager
    {
        public void SendMessage(MessageFormat message)
        {
            throw new NotImplementedException();
        }
    }
    public class SenderManager 
    {
        private ISenderManager _manager;
        public SenderManager(ISenderManager manager)
        {
            _manager = manager;
        }
        public void SendMessage(MessageFormat message)
        {
            _manager.SendMessage(message);
        }
    }
}
