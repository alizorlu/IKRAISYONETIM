using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("PersonellerTB", Schema = "IkraDesk")]
    public class Personeller
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(100)]
        public string AdSoyad { get; set; }
       
        [MaxLength(100)]
        public string Gorevi { get; set; }
      
        [MaxLength(20)]
        public string Telefon { get; set; }
       
        [MaxLength(1000)]
        public string DigerBilgiler { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal ToplamMaasi { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime GirisZamani { get; set; } = DateTime.Now;
        public DateTime MaasTarihi { get; set; } = DateTime.Now.AddDays(30);
    }
}
