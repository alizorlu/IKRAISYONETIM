using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.PersonellerManager;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Personeller
{
    public enum OperasyonelIslem
    {
        Yeni,
        Duzenleme
    }
    
    public partial class frmYeniPersonel : KryptonForm
    {
        //
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IPersonellerManager _personel;
        private OperasyonelIslem _islem;
        //
        
        public int satirSayac = 0;
        public DAL.EntityFramework.Tables.Personeller Personel { get; set; }

        public frmYeniPersonel(OperasyonelIslem islem)
        {
            InitializeComponent();
            
            //Kernels and dip
            _personel = kernel.Get<IPersonellerManager>();
            _islem = islem;
            kryptonLabel1.Text = $"{_islem.ToString()} personel işlemi";
        }
        public frmYeniPersonel(OperasyonelIslem islem,object id)
        {
            _personel = kernel.Get<IPersonellerManager>();
            _islem = islem;
            //kryptonLabel1.Text = $"{_islem.ToString()} personel işlemi";
            this.Personel = _personel.Find((Guid)id);
            personellerBindingSource.AllowNew = true;
            personellerBindingSource.DataSource = Personel;
            personellerBindingSource.DataError += PersonellerBindingSource_DataError;
        }
        protected override void OnLoad(EventArgs e)
        {
            if (_islem == OperasyonelIslem.Yeni)
                this.Personel = _personel.NewPersonel();
            
            personellerBindingSource.AllowNew = true;
            personellerBindingSource.DataSource = Personel;
            personellerBindingSource.DataError += PersonellerBindingSource_DataError;
            this.satirSayac = 0;
        }
        private void PersonellerBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.Lütfen bu işlemi yeniden deneyiniz");
                this.Close();

            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

            if (_islem==OperasyonelIslem.Yeni)
            {
                _personel.Insert(this.Personel);
                basariliLbl.Visible = true;
                MessageBox.Show("Personel başarıyla eklendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Personel = _personel.NewPersonel();
                personellerBindingSource.ResetBindings(true);
                personellerBindingSource.DataSource = this.Personel;
            }
            else if (_islem==OperasyonelIslem.Duzenleme)
            {
                this.Personel=
                    _personel.Update(this.Personel);
                basariliLbl.Visible = true;
                MessageBox.Show("Personel başarıyla düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                personellerBindingSource.ResetBindings(true);
                personellerBindingSource.DataSource = this.Personel;
            }
        }
        private void personelAd_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem == OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }

        private void gorevTxt_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem == OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }

        private void telefonTxt_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem == OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }

        private void girisZamani_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem == OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }

        private void maasTarihi_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem==OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }

        private void maasTutar_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem == OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }

        private void kryptonRichTextBox1_Leave(object sender, EventArgs e)
        {
            ++satirSayac;
            if (satirSayac >= 6&&_islem==OperasyonelIslem.Yeni)
            {
                kaydetBtn.Enabled = true;
            }
            else if (_islem == OperasyonelIslem.Duzenleme)
            {
                kaydetBtn.Enabled = true;
            }
        }
    }
}
