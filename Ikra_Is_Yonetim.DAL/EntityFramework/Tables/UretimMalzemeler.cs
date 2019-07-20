using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("YemekMalzemelerTB",Schema ="IkraGenel")]
    public class UretimMalzemeler
    {
        public Guid Id { get; set; }

        [ForeignKey("Uretim")]
        public Guid UretimId { get; set; }
        public virtual Uretim Uretim { get; set; }
        [ForeignKey("Stok")]
        public Guid StokId { get; set; }
        public virtual Stoklar Stok { get; set; }
    }
}
