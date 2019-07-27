using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.KasaManager;
using Ikra_Is_Yonetim.BL.Ninject;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Kasa
{
    public partial class frmKasaList : KryptonForm
    {
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IKasaManager _kasa;
        private IEnumerable<Kasalar> all;
        private string _donem = String.Empty;
        public frmKasaList()
        {
            InitializeComponent();
            //Kernel
            _kasa = kernel.Get<IKasaManager>();
            //Local
            
        }
        void DonemYukle()
        {
            IEnumerable<string> result = _kasa.Donem();
            donemCombo.Items.Clear();
            foreach (var item in result)
            {
                donemCombo.Items.Add(item);
            }
            if(donemCombo.Items.Count>0)
                donemCombo.SelectedIndex = 0;
        }
        void KarHesaplama(List<Kasalar> list)
        {
            donemLbl.Text = $"{_donem} NET KÂRI :";

            _donemLbl.Text = (list.Where(s => s.IslemTipi == IslemTip.Giris).Sum(f => f.Miktar) -
                list.Where(s => s.IslemTipi == IslemTip.Cikis).Sum(f => f.Miktar)).ToString("0.00 ₺");
            _ayLbl.Text = (
                list.Where(s => s.IslemTarihi.Month == DateTime.Now.Month)
                .Where(s => s.IslemTipi == IslemTip.Giris)
                .Sum(s => s.Miktar)
                -
                list.Where(s => s.IslemTarihi.Month == DateTime.Now.Month)
                .Where(s => s.IslemTipi == IslemTip.Cikis)
                .Sum(s => s.Miktar)).ToString("0.00 ₺");

            var gunBazli = list.Where(sa => sa.IslemTarihi.Year == DateTime.Now.Year && sa.IslemTarihi.Month == DateTime.Now.Month);
            _haftaLbl.Text = (
                gunBazli.Where(sa => sa.IslemTarihi >= DateTime.Now.AddDays(-7))
                .Where(f => f.IslemTipi == IslemTip.Giris)
                .Sum(f => f.Miktar)
                -
                gunBazli.Where(sa => sa.IslemTarihi >= DateTime.Now.AddDays(-7))
                .Where(f => f.IslemTipi == IslemTip.Cikis)
                .Sum(f => f.Miktar)).ToString("0.00 ₺");

            _gunLbl.Text= (
                gunBazli.Where(sa => sa.IslemTarihi.Day==DateTime.Now.Day)
                .Where(f => f.IslemTipi == IslemTip.Giris)
                .Sum(f => f.Miktar)
                -
                gunBazli.Where(sa => sa.IslemTarihi.Day == DateTime.Now.Day)
                .Where(f => f.IslemTipi == IslemTip.Cikis)
                .Sum(f => f.Miktar)).ToString("0.00 ₺");

        }
        void KasaGirislerCikislar(string tip,string donem)
        {

            

            IEnumerable<Kasalar> kasalar
                  = _kasa.All();
            all = kasalar;
            if (donem != null)
            {
                kasalar = kasalar.Where(s => s.Donem.Equals(donem));
            }
            
            if (tip == null)
            {
                List<Kasalar> list = kasalar.ToList();
                kasaGirisCikislarGrid.DataSource
               = list;
                kasaGirisCikislarGrid.Columns["Id"].Visible = false;
                KarHesaplama(list);
            }
            else if (tip=="Tüm İşlemler")
            {
                List<Kasalar> list = kasalar.ToList();
                kasaGirisCikislarGrid.DataSource
                    = list;
                kasaGirisCikislarGrid.Columns["Id"].Visible = false;
                KarHesaplama(list);
            }
            else if (tip=="Avans")
            {
                List<Kasalar> list =
                    kasalar.Where(s => s.Aciklama.Contains("avans")).ToList();
                kasaGirisCikislarGrid.DataSource =list;
                kasaGirisCikislarGrid.Columns["Id"].Visible = false;
                KarHesaplama(list);
            }
            else if (tip=="Maaş")
            {
                List<Kasalar> list =
                    kasalar.Where(s => s.Aciklama.Contains("maaş")).ToList();
                kasaGirisCikislarGrid.DataSource = list;
                kasaGirisCikislarGrid.Columns["Id"].Visible = false;
                KarHesaplama(list);
            }
            else if (tip == "Satış")
            {
                List<Kasalar> list = kasalar.Where(s => s.Aciklama.Contains("satış")).ToList();
                   kasaGirisCikislarGrid.DataSource =list;
                kasaGirisCikislarGrid.Columns["Id"].Visible = false;
                KarHesaplama(list);
            }




            //kasaGirisCikislarGrid.DataSource = null;
        }
        protected override void OnLoad(EventArgs e)
        {
            DonemYukle();
            KasaGirislerCikislar(null,donemCombo.SelectedItem.ToString());
        }

        private void KapatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IslemListelemeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islemListelemeCombo.SelectedIndex!=-1)
            {
                KasaGirislerCikislar(islemListelemeCombo.SelectedItem.ToString(),donemCombo.SelectedItem.ToString());
            }
        }

        private void DonemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (donemCombo.SelectedIndex!=-1)
            {
                _donem = donemCombo.SelectedItem.ToString();
                KasaGirislerCikislar(null, donemCombo.SelectedItem.ToString());
            }
        }
    }
}
