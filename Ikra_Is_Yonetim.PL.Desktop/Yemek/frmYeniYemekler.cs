using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.MalzemeManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.StoklarManager;
using Ikra_Is_Yonetim.BL.YemekManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.EntityFramework.TSQL;
using Ikra_Is_Yonetim.PL.Desktop.UI;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    public partial class frmYeniYemekler : KryptonForm
    {
        private IYemekManager _yemek;
        private ISetSQLQuery _tsql;
        private IMalzemeMananager _malzeme;
        private IStoklarManager _stok;
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        public static Yemekler yemekModel = new Yemekler();
        public static Malzeme _selectedMalzeme { get; set; }
        public frmYeniYemekler()
        {
            InitializeComponent();
            _yemek = kernel.Get<IYemekManager>();
            _malzeme = kernel.Get<IMalzemeMananager>();
            _stok = kernel.Get<IStoklarManager>();
            _tsql = kernel.Get<ISetSQLQuery>();
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
                _yemek.Insert(new Yemekler()
                {
                    PorsiyonGr = yemekModel.PorsiyonGr,
                    YemekId = yemekModel.YemekId,
                    UretimZamani = yemekModel.UretimZamani,
                    YayinDurumu = yemekModel.YayinDurumu,
                    YemekAdi = yemekModel.YemekAdi,
                    YemekAciklamasi = yemekModel.YemekAciklamasi
                }) ;
                foreach (var item in yemekModel.Malzemeler)
                {
                    item.Stok = null;
                    item.Yemek = null;
                    _malzeme.Insert(item);
                   
                }
                foreach (var item in yemekModel.Malzemeler)
                {
                    var stok = _stok.Find(item.StokId);
                    string query =
                        @"Update 
IkraDesktop.StoklarTB 
Set StokKgBirimKalan=@kalan 
Where StokId='@id'";
                   query= query.Replace("@kalan", $"{stok.StokKgBirimKalan - item.KullanimKg}");
                    query= query.Replace("@id", stok.StokId.ToString());
                   int sqlResult= _tsql.SetQuery(query);

                   
                }
                MessageBox.Show("Yemek başarıyla kaydedildi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                yemekModel = new Yemekler();
                yemekModel.Malzemeler = new List<Malzeme>();
                yemeklerBindingSource.ResetBindings(true);
                yemeklerBindingSource.DataSource = yemekModel;
                MalzemeListesiYukle();
                _selectedMalzeme = null;
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
                    = yemekModel.Malzemeler
                    .Select(s => new { s.StokId, s.Stok.StokAdi, s.KullanimKg })
                    .ToList();

                malzemeGridView.Columns["StokAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                malzemeGridView.Columns["StokId"].Visible = false;
            }
        }
        private void MalzemeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_selectedMalzeme == null) return;
            if (yemekModel.Malzemeler == null) yemekModel.Malzemeler = new List<Malzeme>();
            yemekModel.Malzemeler.Add(_selectedMalzeme);
            _selectedMalzeme.Yemek = yemekModel;
            _selectedMalzeme.StokId = _selectedMalzeme.Stok.StokId;
            _selectedMalzeme.YemekId = yemekModel.YemekId;
            MalzemeListesiYukle();
            _selectedMalzeme = null;
        }

        private void StokEkleBtn_LinkClicked(object sender, EventArgs e)
        {

        }

        private void StokSilBtn_Click(object sender, EventArgs e)
        {
            if (malzemeGridView.SelectedRows != null && malzemeGridView.SelectedRows.Count > 0)
            {
                Guid selectedMalzeme
                   = (Guid)malzemeGridView
                   .SelectedRows[0].Cells["StokId"].Value;
                if (yemekModel != null && yemekModel.Malzemeler != null)
                {
                    Malzeme resultmalzeme
                        = yemekModel.Malzemeler.Where(s => s.StokId == selectedMalzeme)
                        .FirstOrDefault();
                    yemekModel.Malzemeler.Remove(resultmalzeme);
                    MalzemeListesiYukle();
                }

            }
            
        }
    }
}
