using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.MalzemeManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.YemekManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
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
    public partial class frmYemekListesi : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IYemekManager _yemek;
        private Yemekler _selectedYemek = null;
        private IMalzemeMananager _malzeme;

        public frmYemekListesi()
        {
            InitializeComponent();
            _yemek = kernel.Get<IYemekManager>();
            _malzeme = kernel.Get<IMalzemeMananager>();
            if (_selectedYemek == null) return;
            yemeklerBindingSource.DataSource = _selectedYemek;
        }
        public void ListLoad()
        {
            IEnumerable<DAL.EntityFramework.Tables.Yemekler> result = _yemek.All();
            yemekList.DataSource = result.ToList();
            yemekList.DisplayMember = "YemekAdi";

        }
        void MalzemeListesiYukle()
        {
            if (_selectedYemek.Malzemeler != null)
            {
                malzemeGridView.DataSource
                    = _selectedYemek.Malzemeler
                    .Select(s => new { s.StokId, s.Stok.StokAdi, s.KullanimKg })
                    .ToList();

                malzemeGridView.Columns["StokAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                malzemeGridView.Columns["KullanimKg"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                malzemeGridView.Columns["StokId"].Visible = false;

                yemekMaaliyetLbl.Text = $"{_selectedYemek.YemekAdi} Yemeğinin Toplam Üretim Maaliyeti :";
                yemekMaaliyetLbl.Values.ExtraText = $"{_malzeme.UretimMaaliyetHesabi(_selectedYemek.Malzemeler.ToList()).ToString("0.00 TL")}";
            }
        }
        protected override void OnActivated(EventArgs e)
        {
            ListLoad();
        }
        private void YeniYemekBtn_Click(object sender, EventArgs e)
        {
            frmYeniYemekler yeniYemek = new frmYeniYemekler();
            yeniYemek.Show();
        }

        private void YemekList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yemekList.SelectedIndex!=-1)
            {
                _selectedYemek = (Yemekler)
                    yemekList.SelectedItem;
                yemeklerBindingSource.DataSource = _selectedYemek;
                yemeklerBindingSource.BindingComplete += YemeklerBindingSource_BindingComplete;
            }
        }

        private void YemeklerBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState==BindingCompleteState.Success)
            {
                MalzemeListesiYukle();
                
            }
        }

        private void YemekList_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedYemek = (Yemekler)
                    yemekList.SelectedItem;
            if (_selectedYemek == null) return;
            yemeklerBindingSource.DataSource = _selectedYemek;
            yemeklerBindingSource.BindingComplete += YemeklerBindingSource_BindingComplete;
            MalzemeListesiYukle();
        }

        private void YemekList_Validated(object sender, EventArgs e)
        {
            _selectedYemek = (Yemekler)
                  yemekList.SelectedItem;
            yemeklerBindingSource.DataSource = _selectedYemek;
            yemeklerBindingSource.BindingComplete += YemeklerBindingSource_BindingComplete;
            MalzemeListesiYukle();
        }

        
    }
}
