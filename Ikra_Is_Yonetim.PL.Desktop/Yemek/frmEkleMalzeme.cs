using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.PL.Desktop.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    public partial class frmEkleMalzeme : KryptonForm
    {
        internal Malzeme malzemeModel = new Malzeme();
        public static Stoklar _selectedStok { get; set; }
        public frmEkleMalzeme()
        {
            InitializeComponent();
            malzemeBindingSource.AllowNew = true;
            malzemeBindingSource.DataSource = malzemeModel;
         _selectedStok = null;
        }

        private void MalzemeEkleBtn_Click(object sender, EventArgs e)
        {
            frmListStok stok = new frmListStok();
            stok.FormClosing += Stok_FormClosing;
            stok.Show();
        }

        private void Stok_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_selectedStok == null) return;
            stokSecimTxt.Text = $"{_selectedStok.StokAdi}";
            //stokSecimTxt.Tag = _selectedStok;
            malzemeModel.Stok = _selectedStok;
        }

        void HataListesiTemizle()
        {
            hataList.Items.Clear();
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            MalzemeValidator
             validation = new MalzemeValidator();
            FluentValidation.Results.ValidationResult
                result = validation.Validate(malzemeModel);
            if (result.IsValid == false)
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
                malzemeModel.KullanimTarihi = DateTime.Now;

                frmYeniYemekler._selectedMalzeme = malzemeModel;
                this.Close();
            }
        }

        private void KullanGr_Validated(object sender, EventArgs e)
        {
            //MessageBox.Show(kullanGr.ToString());
        }
    }
}
