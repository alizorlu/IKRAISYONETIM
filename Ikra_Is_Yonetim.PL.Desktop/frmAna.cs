using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim._3rdApp.EmailManager;
using Ikra_Is_Yonetim._3rdApp.SenderMessageManager;
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

namespace Ikra_Is_Yonetim.PL.Desktop
{
    public partial class frmAna : KryptonForm
    {
        private SenderManager _sender;
        private IEmailManager _email;
        private StandardKernel kernelSingleton = SingletonKernelManager.Instance;
        public frmAna()
        {
            InitializeComponent();
            _email = kernelSingleton.Get<IEmailManager>();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            _sender = new SenderManager(new EmailSender(_email));
            _sender.SendMessage(new MessageFormat()
            {
                Baslik = "Bu bir email sender instance",
                Hedef = "azorlua@gmail.com",
                Icerik = "Email sender mesaj gönderdi size"

            });
        }
    }
}
