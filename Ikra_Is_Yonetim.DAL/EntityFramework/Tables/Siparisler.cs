using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    public enum SiparisDurumu
    {
        Onay,
        Hazırlanıyor,
        Yolda,
        İletildi
    }
    [Table("Siparis", Schema = "IkraGenel")]
    public class Siparisler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [EnumDataType(typeof(SiparisDurumu),ErrorMessage ="Sipariş durumu zorunludur")]
        public SiparisDurumu? SiparisDurum { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        
        [Required(ErrorMessage  ="Kaç kişilik sipariş verilsin?")]
        public int YemekSayisi { get; set; }
        public Guid MusteriId { get; set; }
        public virtual Musteriler Musteri { get; set; }
        public Guid YemekId { get; set; }
        public virtual  Yemekler Yemek{ get; set; }

       

    }
}
