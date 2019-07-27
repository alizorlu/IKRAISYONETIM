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
            stokAc.ShowDialog();
        }
    }
}
