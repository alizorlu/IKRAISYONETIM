using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim._3rdApp.SmsManager;
using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.PL.Desktop.UI;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public partial class frmCarilerList : KryptonForm
    {
        private ICarilerManager _cari;
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private ISMSManager _sms;
        private static readonly object _smsLock = new object();
        private Musteriler _selectedModel { get; set; } = null;
        public frmCarilerList()
        {
            InitializeComponent();
            lock (_smsLock)
            {
                if (_sms == null) _sms = kernel.Get<ISMSManager>();
            }
            _sms.SetAuth();
            _cari = kernel.Get<ICarilerManager>();
            
            if (_selectedModel == null) { cariIslemTop.Enabled = false;return; };
            musterilerBindingSource.DataSource=_selectedModel;
            
        }
        void CariListeYukle()
        {
            IEnumerable<DAL.EntityFramework.Tables.Musteriler> result = _cari.All();
            carilerList.DataSource = result;
            carilerList.DisplayMember = "FirmaAdSoyad";
            kryptonPage1.TextTitle = $"Cariler listesi ({result.Count()})";
            this.Enabled = true;
            if (_selectedModel == null)
            {
                cariIslemTop.Enabled = false;
            }
        }

        //public void MyTestMethod()
        //{
        //    var result = _cari.All();
        //    //foreach (var item in result.ToList())
        //    //{
        //    //    _cari.Delete(item.StokId);
        //    //}
        //    for (int i = 0; i < 2; i++)
        //    {

        //        _cari.Insert(new Musteriler()
        //        {
        //            Email = FakeData.NetworkData.GetEmail(),
        //            FirmaAdres = FakeData.PlaceData.GetAddress(),
        //            FirmaAdSoyad = i%2==0?"Karakoçan Holding":"Harput Dibek",
        //            GunlukYemekFiyati = (decimal)
        //            FakeData.NumberData.GetDouble(),
        //            GunlukYemekSayisi = FakeData.NumberData.GetNumber(10, 15),
        //            KayitTarihi = FakeData.DateTimeData.GetDatetime(),
        //            LastLogin = FakeData.DateTimeData.GetDatetime(),
        //            Telefon = $"053181213{new Random().Next(10, 99)}"
        //        });

        //    }
        //}
        void CariArama(string query)
        {
            if (query == null || query.Length <= 0) return;
            var result
                = _cari.Search(query);
            if (result == null||result.Count()<=0) return;
            carilerList.DataSource = result.ToList();
            carilerList.DisplayMember = "FirmaAdSoyad";
            //kryptonPage1.TextTitle = $"Cari arama sonucu ({result.Count()})";
        }
        protected override void OnActivated(EventArgs e)
        {
            this.Enabled = false;
            CariListeYukle();
            //MyTestMethod();
        }
        private void YeniCariBtn_Click(object sender, EventArgs e)
        {
            frmYeniCari cariEkle = new frmYeniCari();
            cariEkle.FormClosing += CariEkle_FormClosing;
            cariEkle.Show();
        }

        private void CariEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            CariListeYukle();
        }

        private void CarilerAramaTxt_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void CarilerAramaTxt_TextChanged(object sender, EventArgs e)
        {
            if (carilerAramaTxt.Text.Length > 0)
            {
                CariArama(carilerAramaTxt.Text);
            }
            else { CariListeYukle(); }
        }

        private void CariAramaTemizleBtn_Click(object sender, EventArgs e)
        {
            carilerAramaTxt.Clear();
        }

        private void CarilerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carilerList.Items.Count > 0)
            {
                _selectedModel
                    = (Musteriler)
                    carilerList.SelectedItem;
                musterilerBindingSource.DataSource = _selectedModel;
                cariIslemTop.Enabled = true;
                if (topDuzenleBtn.Enabled == false)
                {
                    topDuzenleBtn.Enabled = true;
                    topDuzenleBtn.Text = "Cari Güncelle";
                }
            }
            else cariIslemTop.Enabled = false;
        }

        private void TopDuzenleBtn_Click(object sender, EventArgs e)
        {
            if (_selectedModel!=null)
            {
                CariValidator validator = new CariValidator();
                FluentValidation.Results.ValidationResult
                  result = validator.Validate(_selectedModel);
                if (result.IsValid==false)
                {
                    string hataBilgi = string.Empty;
                    foreach (var item in result.Errors)
                    {
                        hataBilgi += $"{item.ErrorCode}:{item.ErrorMessage}\n";
                    }
                    MessageBox.Show($"Güncellenecek bilgiler tutarlı değil.Aşağıdaki açıklamayı dikkate alınız\n-------------\n{hataBilgi}\n------------\n", "Veriler Doğru Biçimde Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    topDuzenleBtn.Enabled = false;
                    topDuzenleBtn.Text = "Güncellendi...";
                    _cari.Update(_selectedModel);
                }

            }
        }
        void SonrakiCari()
        {
            int index = carilerList.SelectedIndex;
            if ((index+1) > -1&&carilerList.Items.Count-1<(index+1))
            {
                carilerList.SelectedIndex = index + 1;
            }
        }
        void OncekiCari()
        {
            int index = carilerList.SelectedIndex;
            if ((index-1) > -1)
            {
                carilerList.SelectedIndex = index - 1;
            }
        }
        private void CariSilBtn_Click(object sender, EventArgs e)
        {
            if (_selectedModel != null)
            {
                cariSilBtn.Enabled = false;
                _cari.Delete(_selectedModel.Id);
                CariListeYukle();
                musterilerBindingSource.ResetBindings(true);
                musterilerBindingSource.DataSource = null;
                cariSilBtn.Enabled = true;
                CarilerList_SelectedIndexChanged(sender, e);
            }
        }

        private void YeniŞifreGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedModel == null) return;
            //Cari şifresini güncelle
            string yeniSifre = _cari.YeniSifreOlustur();
           var result=
                _cari.SifreGuncelle(_selectedModel.Id, yeniSifre);
            //Yeni şifreyi sms gönder
            bool isSended = _sms.CreateAccountSendSms(new SmsModel() {
                Phone=_selectedModel.Telefon,
                Text=$"Yeni giriş bilgileriniz;\nTelefon:{_selectedModel.Telefon}\nSifre:{yeniSifre}"
            });
            if (isSended==true)
            {
                MessageBox.Show("Yeni şifre bilgisi müşteriye gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifre güncellendi.Fakat müşteriye sms iletilemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
    }
}
