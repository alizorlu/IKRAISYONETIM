using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("SiparislerTB",Schema ="IkraGenel")]
    public class UretimCikislar
    {
        public Guid Id { get; set; }
        [ForeignKey("Uretim")]
        public Guid UretimId { get; set; }
        public virtual Uretim Uretim { get; set; }

        [ForeignKey("Musteri")]
        public Guid MusteriId { get; set; }
        public virtual Musteriler Musteri { get; set; }

        public DateTime CikisTarihi { get; set; }
        public bool OdemeYapildiMi { get; set; } = false;
        public bool SiparisOnaylandiMi { get; set; } = false;

    }
}
