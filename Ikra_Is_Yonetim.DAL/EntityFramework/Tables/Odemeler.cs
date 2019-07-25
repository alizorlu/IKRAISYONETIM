using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("KasaTB",Schema ="IkraGenel")]
    public class Odemeler
    {
        public Guid Id { get; set; }
        public string Aciklama { get; set; }
        public decimal GirenTutar { get; set; }
        public decimal CikanTutar { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}
