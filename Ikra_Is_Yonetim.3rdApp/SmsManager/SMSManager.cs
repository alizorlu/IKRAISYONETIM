using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim._3rdApp.SmsManager
{
    public interface ISMSManager
    {
        bool TekSmsGonder(SmsModel model);
        bool CreateAccountSendSms(SmsModel model);
        void SetAuth(SmsAuthModel model);
        void SetAuth();//Default
    }
   
    public class VatanSMS : ISMSManager
    {
        
        private Oztek.OztekSmsWebServicePortType _service { get; set; }
        private Oztek.OztekSmsWebServicePortType _service2 { get; set; }
        private SmsAuthModel _auth;
        public VatanSMS()
        {
            
            //_service2 = new Oztek.OztekSmsWebServicePortTypeClient();
            _service = new Oztek.OztekSmsWebServicePortTypeClient(new System.ServiceModel.BasicHttpBinding(), new EndpointAddress("http://panel.vatansms.com/webservis/service.php"));
            
            ////_service.Endpoint.Contract = new System.ServiceModel.Description.ContractDescription("");
            //_service.Endpoint.Binding = new System.ServiceModel.BasicHttpBinding("OztekSmsWebServiceBinding");
            //_service.Endpoint.Address = new EndpointAddress("http://panel.vatansms.com/webservis/service.php");
            //_service.Endpoint.Binding.SendTimeout = new TimeSpan(0, 0, 0, 2000);
            //if (_service.State == CommunicationState.Closed) 
        }

        public void SetAuth(SmsAuthModel model)
        {
            _auth = model;
        }
        public void SetAuth() => _auth = new SmsAuthModel().getDefaultAuth();
        public bool CreateAccountSendSms(SmsModel model)
        {

            if (model != null)
            {
                model.Phone = model.Phone.StartsWith("0") ? model.Phone.Remove(0, 1) : model.Phone;
            }
            //model.Text = "Test sms";
            return TekSmsGonder(model);
        }

        public bool TekSmsGonder(SmsModel model)
        {

            Oztek.TekSmsiBirdenCokNumarayaGonderResponse result =
                  _service.TekSmsiBirdenCokNumarayaGonder(new Oztek.TekSmsiBirdenCokNumarayaGonderRequest()
                  {
                      kullanicino = _auth.kullanicino,
                      kullaniciadi = _auth.kullaniciadi,
                      sifre = _auth.kullanicisifre,
                      orjinator = _auth.orjinator,
                      numaralar = model.Phone,
                      mesaj = model.Text,
                      zaman = "",
                      zamanasimi = "",
                      tip = "Turkce"
                  });
            //string result = _service.TekSmsiBirdenCokNumarayaGonder(kullanicino: _auth.kullanicino,
            //      kullaniciadi: _auth.kullaniciadi,
            //      sifre: _auth.kullanicisifre,
            //      orjinator: _auth.orjinator,
            //      numaralar: model.Phone,
            //      mesaj: model.Text,
            //      zaman: "",
            //      zamanasimi: "",
            //      tip: "Turkce") as string;
            if (result.@return.Contains("OK")) return true;
            else return false;
        }
    }

    public class SmsAuthModel
    {
        public string kullanicino { get; set; }
        public string kullaniciadi { get; set; }
        public string kullanicisifre { get; set; }
        public string orjinator { get; set; }
        public SmsAuthModel getDefaultAuth()
        {
            return new SmsAuthModel() {
                kullaniciadi= "05530496623",
                kullanicino= "33533",
                kullanicisifre="23231453",
                orjinator= "IKRA YEMEK"
            };
        }
        public SmsAuthModel setAuth(string ad, string no, string sifre, string orjinator)
            => new SmsAuthModel() { kullaniciadi=ad,orjinator=orjinator,kullanicisifre=sifre,kullanicino=no};
    }
    public class SMSManager :ISMSManager
    {
        private ISMSManager _manager;
        public SMSManager(ISMSManager manager)
        {
            _manager = manager;
            
        }
        public bool CreateAccountSendSms(SmsModel model)
        {
            return _manager.CreateAccountSendSms(model);
        }

        public void SetAuth(SmsAuthModel model)
        {
            _manager.SetAuth(model);
        }

        public void SetAuth()
        {
            _manager.SetAuth();
        }

        public bool TekSmsGonder(SmsModel model)
        {
            return _manager.TekSmsGonder(model);
        }
    }
}
