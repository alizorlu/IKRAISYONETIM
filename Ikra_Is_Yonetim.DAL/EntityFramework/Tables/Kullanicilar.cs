using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    public enum KullanicilarType
    {
        Admin,
        Personel,
        Musteri
    }
    [Table("Kullanicilar",Schema ="IkraGenel")]
    public class Kullanicilar
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [EnumDataType(typeof(KullanicilarType), ErrorMessage = "Kullanıcı tipi zorunlu")]
        public KullanicilarType? Tip { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime LastLogin { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public bool IsState { get; set; } = true;
        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; }
        public int MealCount { get; set; } = 0;


    }
}
