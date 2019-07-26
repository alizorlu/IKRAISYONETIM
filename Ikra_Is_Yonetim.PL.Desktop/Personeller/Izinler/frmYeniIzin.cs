using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.IzinlerManager;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Personeller.Izinler
{
    public partial class frmYeniIzin : KryptonForm
    {


        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IizinlerManager _izin;
        DAL.EntityFramework.Tables.Izinler model = new DAL.EntityFramework.Tables.Izinler();
        private Guid _personel;
        public frmYeniIzin(Guid personalid)
        {
            InitializeComponent();
            _izin = kernel.Get<IizinlerManager>();
            _personel = personalid;
        }
        
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (baslangic.Value.Date>=DateTime.Now.Date)
            {
                if (bitis.Value > baslangic.Value)
                {
                    _izin.Insert(new DAL.EntityFramework.Tables.Izinler()
                    {
                        IzinSuresi = bitis.Value,
                        IzinTarihi = baslangic.Value,
                        PersonelId = _personel,
                        MaastanDusurulduMu = false
                    });
                    MessageBox.Show("İzin başarıyla eklendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İzin bitiş tarihi başlangıç tarihinden büyük olmalı");
                    return;
                }
            }
            else
            {
                MessageBox.Show("İzin başlangıç tarihi bugünden büyük ya da bugüne eşit olmalıdır.");
                return;
            }
            
        }

        private void kryptonDateTimePicker1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
