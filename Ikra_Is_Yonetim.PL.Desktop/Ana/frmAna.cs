using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ikra_Is_Yonetim.PL.Desktop.Ana
{
    public partial class frmAna : KryptonForm
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personellerBtn_Click(object sender, EventArgs e)
        {
            Personeller.frmPersonellerList
                pList = new Personeller.frmPersonellerList();
            pList.Show();
        }

        private void KasaBtn_Click(object sender, EventArgs e)
        {
            Kasa.frmKasaList kasaAc = new Kasa.frmKasaList();
            kasaAc.Show();
        }

        private void StokBtn_Click(object sender, EventArgs e)
        {
            Stok.frmStoklarList stokAc = new Stok.frmStoklarList();
            stokAc.Show();
        }

        private void FirmalarBtn_Click(object sender, EventArgs e)
        {
            Firmalar.frmFirmalarList firmaAc = new Firmalar.frmFirmalarList();
            firmaAc.Show();
        }

        private void YemekBtn_Click(object sender, EventArgs e)
        {
            Yemek.frmYemekListesi yemekList = new Yemek.frmYemekListesi();
            yemekList.Show();
        }

        private void CariBtn_Click(object sender, EventArgs e)
        {
            Cariler.frmCarilerList cariListe = new Cariler.frmCarilerList();
            cariListe.Show();
        }

        private void SiparisBtn_Click(object sender, EventArgs e)
        {
            Siparis.frmSiparislerList siparisListe = new Siparis.frmSiparislerList();
            siparisListe.Show();
        }
    }
}
