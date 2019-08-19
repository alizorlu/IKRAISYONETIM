using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("SiparisOdemeTB", Schema = "IkraGenel")]
    public class SiparisOdeme
    {
       
        [Key]
        public Guid OdemeId { get; set; } = Guid.NewGuid();      
        public string KartBinNumber { get; set; }
        public string SonDortHane { get; set; }
        public string Kart { get; set; }
        public string KartTip { get; set; }
        public string KartAile { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public string OdemeTutari { get; set; }
        public string NetOdemeTutari { get; set; }
    }
}
