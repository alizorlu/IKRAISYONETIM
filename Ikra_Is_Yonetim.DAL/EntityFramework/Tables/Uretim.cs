using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("YemeklerTB", Schema = "IkraDesktop")]
    public class Uretim
    {
        public Guid Id { get; set; }
        public string UretimAdi { get; set; }
        public DateTime UretimZamani { get; set; }
        [Column(TypeName = "Money")]
        public decimal BirimFiyat1 { get; set; }       
    }
}
