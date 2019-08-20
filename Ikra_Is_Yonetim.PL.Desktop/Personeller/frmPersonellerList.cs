using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.AvanslarManager;
using Ikra_Is_Yonetim.BL.IzinlerManager;
using Ikra_Is_Yonetim.BL.MaasManager;
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
    public partial class frmPersonellerList : KryptonForm
    {
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IPersonellerManager _personel;
        private IizinlerManager _izin;
        private IAvansManager _avans;
        private IMaasManager _maas;
        internal DAL.EntityFramework.Tables.Personeller _selected;
        
        public frmPersonellerList()
        {
            InitializeComponent();
            _personel = kernel.Get<IPersonellerManager>();
            _izin = kernel.Get<IizinlerManager>();
            _avans = kernel.Get<IAvansManager>();
            _maas = kernel.Get<IMaasManager>();
        }
        public void YenileMaas()
        {
            if (_selected != null)
            {

                IEnumerable<DAL.EntityFramework.Tables.Maaslar> result
                    = _maas.All(_selected.Id);
                maasGridView.DataSource = result;
                //maasGridView.Columns["StokId"].Visible = false;
                maasGridView.Columns["Id"].Visible = false;
                maasGridView.Columns["Personel"].Visible = false;
            }

        }
        public void YenileAvans()
        {
            if (_selected != null)
            {
                IEnumerable<DAL.EntityFramework.Tables.Avanslar> result = _avans.All(_selected.Id);
                avansGridView.DataSource = result;
                //avansGridView.Columns["StokId"].Visible = false;
                avansGridView.Columns["Personel"].Visible = false;
                avansGridView.Columns["Id"].Visible = false;
            }
            
        }
        public void YenileIzin()
        {
            if (_selected!=null)
            {
                IEnumerable<DAL.EntityFramework.Tables.Izinler> resultIzin
                    = _izin.All(_selected.Id);


                izinlerGridView.DataSource = resultIzin;
                izinlerGridView.Columns["Personel"].Visible = false;
                izinlerGridView.Columns["Id"].Visible = false;
                //izinlerGridView.Columns["StokId"].Visible = false;
            }
        }
        public void Yenile()
        {
           
            personalListbox.DataSource = _personel.All();
            personalListbox.DisplayMember = "AdSoyad";
            if (personalListbox.Items.Count>0)
            {
                personelViewTab.Visible = true;
                _selected = (DAL.EntityFramework.Tables.Personeller)
                   personalListbox.SelectedItem;
                personellerBindingSource.DataSource = _selected;
                topDuzenleBtn.Enabled = true;
                personelIslemlerTab.Visible = true;
                topSilBtn.Enabled = true;
            }
            else
            {
                personelViewTab.Visible = false;
                personelIslemlerTab.Visible = false;
                topDuzenleBtn.Enabled = false;
                topSilBtn.Enabled = false;
            }
            guncellbl.Visible = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            Yenile(); 
        }
        private void yeniPersonelBtn_Click(object sender, EventArgs e)
        {
            frmYeniPersonel yeni = new frmYeniPersonel(OperasyonelIslem.Yeni);
            yeni.Show();
            yeni.FormClosing += Yeni_FormClosing;
            
        }

        private void Yeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Yenile();
            YenileIzin();
            YenileAvans();
            YenileMaas();
        }

        private void personalListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personalListbox.Items.Count>0)
            {
                _selected = (DAL.EntityFramework.Tables.Personeller)
                    personalListbox.SelectedItem;
                personellerBindingSource.DataSource = _selected;
                duzenleBtn.Enabled = true;
                topDuzenleBtn.Enabled = true;
                YenileIzin();
                YenileAvans();
                YenileMaas();
                
            }
        }

        private void yeniPersonelBtn_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (_selected!=null)
            {
                _personel.Delete((Guid)_selected.Id);
                personellerBindingSource.ResetBindings(true);
                Yenile();
                YenileIzin();
                YenileAvans();
                YenileMaas();
            }
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            if (_selected!=null)
            {
                _personel.Update(_selected);
                guncellbl.Visible = true;
                duzenleBtn.Enabled = false;
                topDuzenleBtn.Enabled = false;
                Yenile();
                YenileIzin();
                YenileAvans();
                YenileMaas();
            }
        }

        private void frmPersonellerList_Load(object sender, EventArgs e)
        {
            personellerBindingSource.CurrencyManager.Position = 0;
        }

        private void topDuzenleBtn_Click(object sender, EventArgs e)
        {
            duzenleBtn_Click(sender, e);
        }

        private void topSilBtn_Click(object sender, EventArgs e)
        {
            silBtn_Click(sender, e);
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            Yenile();
        }

       

        private void Ac_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Yenile();
            YenileIzin();
            YenileAvans();
            YenileMaas();
        }

        private void izinlerGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                DAL.EntityFramework.Tables.Izinler selected
               = (DAL.EntityFramework.Tables.Izinler)
               izinlerGridView.Rows[e.RowIndex].DataBoundItem;
                izinSilBtn.Enabled = true;
                izinSilBtn.Tag = (Guid)selected.Id;
            }
            catch (Exception)
            {

                izinSilBtn.Enabled = false;
            }
        }

        private void izinSilBtn_Click(object sender, EventArgs e)
        {
            if (izinSilBtn.Tag != null)
            {
                DialogResult cevap = MessageBox.Show("Bu izin bilgisini silerseniz,personel maaşında artış olacaktır.Personel maaşı gün bazında hesaplanacağı için silinen izin günü kadar maaş artışı yapılır.Silmek istediğinize emin misiniz?", "Silinsin Mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap==DialogResult.Yes)
                {
                    _izin.Delete(_izin.Find((Guid)izinSilBtn.Tag));
                    izinSilBtn.Tag = null;
                    //Yenile();
                    YenileIzin();
                    YenileAvans();
                    YenileMaas();
                }
            }
        }

        private void izinYenileBtn_Click(object sender, EventArgs e)
        {
            YenileIzin();
            
        }

        private void izinVerBtn_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {

                Izinler.frmYeniIzin ac = new Izinler.frmYeniIzin(_selected.Id);
                ac.Show();
                ac.FormClosing += Ac_FormClosing;
            }
        }

        private void avansTanimlaBtn_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Avanslar.frmYeniAvans avansac = new Avanslar.frmYeniAvans(_selected.Id);
                avansac.FormClosing += Avansac_FormClosing;
                avansac.Show();
                
            }
           

        }

        private void Avansac_FormClosing(object sender, FormClosingEventArgs e)
        {
            YenileAvans();
        }

        private void avansYenileBtn_Click(object sender, EventArgs e)
        {
            YenileAvans();
        }

        private void maasOdemeBtn_Click(object sender, EventArgs e)
        {
            if (_selected!=null)
            {

                Maaslar.frmMaasOdemsi maasOdemeYap = new Maaslar.frmMaasOdemsi((Guid)_selected.Id);
                maasOdemeYap.FormClosing += MaasOdemeYap_FormClosing;
                maasOdemeYap.ShowDialog();
            }
        }

        private void MaasOdemeYap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Yenile();
            YenileIzin();
            YenileAvans();
            YenileMaas();
        }
    }
}
