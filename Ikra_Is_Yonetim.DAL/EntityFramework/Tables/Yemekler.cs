using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("Yemekler", Schema = "IkraGenel")]
    public class Yemekler
    {
        [Key]
        public Guid YemekId { get; set; } = Guid.NewGuid();
        public string YemekAdi { get; set; }
        public decimal PorsiyonGr { get; set; }
        public DateTime UretimZamani { get; set; } = DateTime.Now;
        public bool YayinDurumu { get; set; }
        [DataType(DataType.Text)]
        public string YemekAciklamasi { get; set; }

        public virtual ICollection<Malzeme> Malzemeler { get; set; }

    }
}
