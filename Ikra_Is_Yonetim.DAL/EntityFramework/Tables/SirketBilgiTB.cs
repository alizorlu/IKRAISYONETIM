using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("SirketBilgiTB", Schema = "IkraGenel")]
    public class SirketBilgiTB
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string VATNo { get; set; }
        public string SiteName { get; set; }
        public string Logo { get; set; }
    }
}
