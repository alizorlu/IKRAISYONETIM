using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.AvanslarManager;
using Ikra_Is_Yonetim.BL.Ninject;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Personeller.Avanslar
{
    public partial class frmYeniAvans : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IAvansManager _avans;
        private DAL.EntityFramework.Tables.Avanslar avans;
        public frmYeniAvans(Guid personelid)
        {
            InitializeComponent();
            avans = new DAL.EntityFramework.Tables.Avanslar();
            avans.Id = Guid.NewGuid();
            avans.PersonelId = personelid;

            avans.AvansTarihi = DateTime.Now;
            avans.MaastanDusulduMu = false;

            //Kernels
            _avans = kernel.Get<IAvansManager>();
            
        }

       

        private void frmYeniAvans_Load(object sender, EventArgs e)
        {

            avanslarBindingSource.DataSource = avans;
        }
        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _avans.Insert(avans);
                MessageBox.Show("Avans işlemi başarıyla tanımlandı.Şimdi personel anasayfasına döneceksiniz.","Başarılı");
                this.Close();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
