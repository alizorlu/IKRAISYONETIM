using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.KullaniciManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Ikra_Is_Yonetim.Utilities.PasswordCreateManager;
using Ikra_Is_Yonetim.Utilities.RegexManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Hesaplar
{
    public partial class frmAdd : KryptonForm
    {
        StandardKernel _kernel = new StandardKernel();
        IKullaniciManager _kullanici;
        IRegexManager _regex;
        IPasswordCreateManager _passManager;
        IHashManager _hash;
        private Kullanicilar _model;
        public frmAdd()
        {
            InitializeComponent();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _kullanici = _kernel.Get<IKullaniciManager>();
            _passManager = _kernel.Get<IPasswordCreateManager>();
            _regex = _kernel.Get<IRegexManager>();
            _hash = _kernel.Get<IHashManager>();

            _model = new Kullanicilar();
            _model.Id = Guid.NewGuid();
            hesapTipCombo.DataSource = Enum.GetValues(typeof(KullanicilarType));
        }
        private void Temizle()
        {
            nameSurnameTxt.Clear();
            usernameTxt.Clear();
            emailTxt.Clear();
            phoneTxt.Clear();
            addresTxt.Clear();
            mealCountNumeric.Value = 0;
            _model = new Kullanicilar();
            hesapTipCombo.Focus();
        }
        private void nameSurnameTxt_TextChanged(object sender, EventArgs e)
        {
            _model.AdSoyad = nameSurnameTxt.Text;
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            _model.UserName = usernameTxt.Text;
        }
        string inEmail = string.Empty;
        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailTxt.Text.Contains("@") && emailTxt.Text.Contains("."))
            {

                inEmail = emailTxt.Text;
                //Email formatı doğru mu?
               
                Kullanicilar query = _kullanici.QueryEmail(inEmail);
                if (query == null)
                {
                    _model.Email = inEmail;
                }
                else
                {
                    MessageBox.Show("Bu email kayıtlı", "Kayıtlı Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inEmail = "";
                    emailTxt.Clear();
                    emailTxt.Focus();
                }
            }
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            //var sa = _model;
            bool result = _regex.isValidEmail(_model.Email);
            if (result == false)
            {
                MessageBox.Show("Email formatı düzgün girilmedi.\nÖrn:birisi@site.com", "Hata Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTxt.Clear();
                emailTxt.Focus();
                return;
            }          
            if (_model.Phone == null) { MessageBox.Show("Telefon numarası boş olamaz.");
                phoneTxt.Clear();
                phoneTxt.Focus();
                return;
            }
            if (_model.Phone.Length>10)
            {
                Kullanicilar query = _kullanici.Query(_model.Phone);
                if (query != null)
                {
                    MessageBox.Show("Bu numara daha önce sisteme kaydedilmiş");
                    phoneTxt.Clear();
                    phoneTxt.Focus();
                    return;
                }
            }
            if (_model.UserName == null)
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.");
                usernameTxt.Clear();
                usernameTxt.Focus();return;
            }
            string pass = _passManager.GetNewPass(_model.Tip);
            //Burada SMS Gönderilecek

            _model.Password = _hash.Create(pass);
            _model.CreateTime = DateTime.Now;
            _model.LastLogin = DateTime.Now;
            _kullanici.Insert(_model);
            Temizle();
            MessageBox.Show("Hesap başarıyla eklenmiştir.Hesap bilgileri girilen telefon numarasına SMS olarak iletilecektir.","Kayıt başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void hesapTipCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hesapTipCombo.SelectedIndex!=-1)
            {
                _model.Tip =(KullanicilarType)hesapTipCombo.SelectedItem;
            }
        }

        
        private void addresTxt_TextChanged(object sender, EventArgs e)
        {
            _model.Address = addresTxt.Text;
        }

        private void mealCountNumeric_ValueChanged(object sender, EventArgs e)
        {
            _model.MealCount =(int)mealCountNumeric.Value;
        }

        private void phoneTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //_model.Phone = phoneTxt.Text;
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            _model.Phone = phoneTxt.Text;
        }
    }
}
