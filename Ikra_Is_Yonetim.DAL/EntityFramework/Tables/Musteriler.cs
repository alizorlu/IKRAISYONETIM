using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("MusterilerTB",Schema ="IkraGenel")]
    public class Musteriler
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }
        [Required]
        [MinLength(4)]
        public string FirmaAdSoyad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        public DateTime LastLogin { get; set; }
        [Required]
        public int GunlukYemekSayisi { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string FirmaAdres { get; set; }
            
        public decimal GunlukYemekFiyati { get; set; }
        public string GeciciPassword { get; set; }
        public ICollection<Siparisler> Siparisler { get; set; }
    }
}
