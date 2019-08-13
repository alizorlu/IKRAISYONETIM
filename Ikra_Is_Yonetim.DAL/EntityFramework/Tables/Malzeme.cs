using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("MalzemeKullanimTB", Schema = "IkraDesk")]
    public class Malzeme
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal KullanimKg { get; set; }      
        public DateTime KullanimTarihi { get; set; }
        [ForeignKey("Stok")]
        public Guid StokId { get; set; }
        [ForeignKey("Yemek")]
        public Guid YemekId { get; set; }
        public virtual Yemekler Yemek { get; set; }
      
        public virtual Stoklar Stok { get; set; }
    }
}
