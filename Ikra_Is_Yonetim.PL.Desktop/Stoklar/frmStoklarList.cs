using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Stoklar
{
    public partial class frmStoklarList : KryptonForm
    {
        public frmStoklarList()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.'||e.KeyChar==(char)Keys.Delete||e.KeyChar==(char)Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

      
        

        private void textBox1_Leave(object sender, EventArgs e)
        {
            decimal amount = 0.0m;
            if (Decimal.TryParse(stokFiyati.Text, NumberStyles.Currency, null, out amount))
            {

                stokFiyati.Text = amount.ToString("C", CultureInfo.CreateSpecificCulture("tr-TR"));
            }

        }

        private void yeniStokKryptonBtn_Click(object sender, EventArgs e)
        {
            stokIslemNavigator.Visible = true;
            yeniStokEkleTab.Visible = true;
        }
    }
}
