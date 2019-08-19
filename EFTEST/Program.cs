using Ikra_Is_Yonetim._3rdApp.SmsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //MalzemeTb malzeme = new MalzemeTb();
            //YemekTb yemek = new YemekTb();
            VatanSMS vatan = new VatanSMS();
            
            SMSManager sms = new SMSManager(vatan);
            sms.SetAuth();
            sms.TekSmsGonder(new SmsModel()
            {
                Phone = "5318121351",
                Text = "Deneme sms'i"
            }); 
        }
    }
}
