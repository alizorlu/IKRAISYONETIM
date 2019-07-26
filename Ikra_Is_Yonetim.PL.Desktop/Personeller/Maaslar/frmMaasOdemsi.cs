//using Ikra_Is_Yonetim._3rdApp.Invoicer.InvoicerGenerator;
using Ikra_Is_Yonetim.BL.MaasManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Personeller.Maaslar
{
    public partial class frmMaasOdemsi : Form
    {
        private Guid _id { get; set; }
        public frmMaasOdemsi(Guid id)
        {
            InitializeComponent();
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaasManager manager = new MaasManager(new EFMaasManager());
            manager.MaasInvoice(_id);
        }
    }
}
