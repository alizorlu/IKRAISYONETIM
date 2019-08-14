using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("CariLoginLog",Schema ="")]
    public class CariAuthenticationLog
    {
        public Guid Id { get; set; }
        public Guid MusteriId { get; set; }
        public virtual Musteriler Musteri { get; set; }

        public DateTime LoginTime { get; set; }

    }
}
