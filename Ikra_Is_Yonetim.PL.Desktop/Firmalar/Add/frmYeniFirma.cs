using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.FirmalarManager;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Firmalar.Add
{
    public partial class frmYeniFirma : KryptonForm
    {
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IFirmalarManager _firma;
        public DAL.EntityFramework.Tables.Firmalar Firma { get; set; }
        public frmYeniFirma()
        {
            InitializeComponent();
            _firma = kernel.Get<IFirmalarManager>();
            if (Firma == null) Firma = new DAL.EntityFramework.Tables.Firmalar();
            firmalarBindingSource.AllowNew = true;
            firmalarBindingSource.DataSource = Firma;
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _firma.Insert(Firma);
                MessageBox.Show("Firma başarıyla kaydedildi.", "Kayıt başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Firma = new DAL.EntityFramework.Tables.Firmalar();
                firmalarBindingSource.ResetBindings(true);
                firmalarBindingSource.DataSource = Firma;
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.Şimdi bu ekran kapatılıyor...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            //var sa = firmalarBindingSource.DataSource;
            //var fa = Firma;
            
        }
    }
}
