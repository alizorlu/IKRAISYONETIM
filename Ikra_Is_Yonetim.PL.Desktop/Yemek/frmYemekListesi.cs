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

namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    public partial class frmYemekListesi : KryptonForm
    {
        public frmYemekListesi()
        {
            InitializeComponent();
        }

        private void YeniYemekBtn_Click(object sender, EventArgs e)
        {
            frmYeniYemekler yeniYemek = new frmYeniYemekler();
            yeniYemek.Show();
        }
    }
}
