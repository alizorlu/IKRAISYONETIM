using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.SirketManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop
{
    public partial class frmGiris : KryptonForm
    {
       

        public frmGiris()
        {
            InitializeComponent();
           
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
           

            Ana.frmAna ac = new Ana.frmAna();
            ac.ShowDialog();
        }
    }
}
