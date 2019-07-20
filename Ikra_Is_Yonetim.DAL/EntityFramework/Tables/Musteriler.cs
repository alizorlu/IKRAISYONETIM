using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("MusterilerTB",Schema ="IkraGenel")]
    public class Musteriler
    {
        public Guid Id { get; set; }
        public string Telefon { get; set; }
        public string FirmaAdSoyad { get; set; }
        public string Email { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime LastLogin { get; set; }
        public int GunlukYemekSayisi { get; set; }
    }
}
