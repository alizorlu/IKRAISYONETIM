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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Key]
        public Guid OdemeId { get; set; }
        public string Odeme { get; set; }

    }
}
