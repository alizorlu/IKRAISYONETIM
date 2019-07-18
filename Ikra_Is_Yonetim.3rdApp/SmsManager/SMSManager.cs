using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim._3rdApp.SmsManager
{
    public interface ISMSManager
    {
        bool CreateAccountSendSms(SmsModel model);
    }
    public class VatanSMS : ISMSManager
    {
        public bool CreateAccountSendSms(SmsModel model)
        {
            //Gönderildi varsayalım
            return true;
        }
    }
    public class SMSManager
    {
    }
}
