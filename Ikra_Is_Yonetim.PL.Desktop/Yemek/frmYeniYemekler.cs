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
    public partial class frmYeniYemekler : KryptonForm
    {
        public static Yemekler yemekModel = new Yemekler();
        private List<Malzeme> _selectedMalzemeler = new List<Malzeme>();
        public static Malzeme _selectedMalzeme { get; set; }
        public frmYeniYemekler()
        {
            InitializeComponent();
            yemeklerBindingSource.AllowNew = true;
            yemeklerBindingSource.DataSource = yemekModel;
            UretimDate.MinDate = DateTime.Now;
        }
        void HataListesiTemizle() => hataList.Items.Clear();
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            YemekValidator
                validation = new YemekValidator();
            FluentValidation.Results.ValidationResult
                result = validation.Validate(yemekModel);
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
            }
        }

        private void StokEkleBtn_Click(object sender, EventArgs e)
        {
            frmEkleMalzeme malzemeEkle = new frmEkleMalzeme();
            malzemeEkle.FormClosing += MalzemeEkle_FormClosing;
            malzemeEkle.Show();
        }
        void MalzemeListesiYukle()
        {
            if (yemekModel.Malzemeler != null)
            {
                malzemeGridView.DataSource
                    = yemekModel.Malzemeler.Select(s=>new { s.Stok.StokAdi,s.KullanimKg})
                    .ToList();
                malzemeGridView.Columns["StokAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void MalzemeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_selectedMalzeme == null) return;
            if (yemekModel.Malzemeler == null) yemekModel.Malzemeler = new List<Malzeme>();
            yemekModel.Malzemeler.Add(_selectedMalzeme);
            MalzemeListesiYukle();
            _selectedMalzeme = null;
        }

        private void StokEkleBtn_LinkClicked(object sender, EventArgs e)
        {

        }
    }
}
