using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim._3rdApp.SmsManager;
using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.PL.Desktop.UI;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Cariler
{
    public partial class frmYeniCari : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private ICarilerManager _cari;
        private ISMSManager _sms;
        private IHashManager _hash;
        private Musteriler _cariModel = new Musteriler();
        public frmYeniCari()
        {
            InitializeComponent();
            _cari = kernel.Get<ICarilerManager>();
            _sms = kernel.Get<ISMSManager>();
            _sms.SetAuth();
            _hash = kernel.Get<IHashManager>();
            musterilerBindingSource.AllowNew = true;
            musterilerBindingSource.DataSource = _cariModel;
        }
        void HataListesiTemizle() => this.hataList.Items.Clear();
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            CariValidator validator = new CariValidator();
            FluentValidation.Results.ValidationResult
              result = validator.Validate(_cariModel);
            if (result.IsValid==false)
            {
                HataListesiTemizle();
                foreach (var item in result.Errors)
                {
                    hataList.Items.Add($"{item.ErrorCode}:\t{item.ErrorMessage}");
                }
            }
            else
            {
                HataListesiTemizle();
                
                _cariModel.LastLogin = _cariModel.KayitTarihi;
                string pass = _cari.YeniSifreOlustur();
                _cariModel.GeciciPassword =
                    _hash.Create(pass);
                _cari.Insert(_cariModel);
                var smsModel =
                    new SmsModel()
                    {
                        Phone = _cariModel.Telefon,
                        Text = $"{_cariModel.FirmaAdSoyad} hoş geldiniz.Giriş bilgileriniz:\nTelefon:{_cariModel.Telefon}\nŞifre:{pass}\nbu bilgiler size özeldir.Kimseyle paylaşmayın."

                    };
               bool isSended= _sms.CreateAccountSendSms(smsModel);
                if (isSended == false)
                {
                   DialogResult cevap= MessageBox.Show("Müşteri kaydı yapıldı fakat sms gönderilemedi.Tekrar denensin mi?","Sms gönderilemedi",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                    if (cevap==DialogResult.Yes)
                    {
                       isSended= _sms.CreateAccountSendSms(smsModel);
                        if (isSended)
                        {
                            MessageBox.Show("Firmaya kayıt sms'i iletildi");
                            
                        }
                    }
                }
                _cariModel = new Musteriler();
                musterilerBindingSource.AllowNew = true;
                musterilerBindingSource.DataSource = _cariModel;
                MessageBox.Show("Cari başarıyla kaydedildi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }
        }
    }
}
