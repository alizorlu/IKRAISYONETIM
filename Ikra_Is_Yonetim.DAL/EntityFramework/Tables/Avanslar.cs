using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("PersonelAvansTB", Schema = "IkraDesk")]
    public class Avanslar
    {
        public Guid Id { get; set; }

        [ForeignKey("Personel")]
        public Guid  PersonelId{ get; set; }
        public virtual Personeller Personel { get; set; }

        public decimal AvansTutari { get; set; }
        public DateTime AvansTarihi { get; set; }
    }
}
