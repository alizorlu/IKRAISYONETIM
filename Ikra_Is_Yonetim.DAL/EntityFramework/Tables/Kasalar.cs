using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    public enum IslemTip
    {
        Giris,
        Cikis
    }
    [Table("KasalarTB",Schema ="IkraGenel")]
   public class Kasalar
    {
        public Guid Id { get; set; }
        public string Donem { get; set; }
        public decimal Miktar { get; set; }
        public string Aciklama { get; set; }
        public DateTime IslemTarihi { get; set; }
        public IslemTip IslemTipi { get; set; }
    }
}
