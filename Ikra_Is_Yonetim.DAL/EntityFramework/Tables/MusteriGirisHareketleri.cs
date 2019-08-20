using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    public enum HareketTipleri
    {
        Giris,
        Cikis,
        Sifre_Degistirme,
        Odeme,
        Siparis
    }
    [Table("MusteriGirisleri",Schema ="IkraWeb")]
    public class MusteriGirisHareketleri
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? MusteriId { get; set; }
        public virtual Musteriler Musteri { get; set; }
        public string IslemAciklama { get; set; }
        public DateTime IslemTarihi { get; set; }
        public HareketTipleri? Islem { get; set; }
        public string CihazIp { get; set; }
        public string CihazBrowser { get; set; }        
        public string CihazBrowserAnonId { get; set; }
    }
}
