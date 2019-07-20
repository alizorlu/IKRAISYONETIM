using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("StoklarTB",Schema ="IkraDesktop")]
    public class Stoklar
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string StokAdi { get; set; }
        public decimal StokTutari { get; set; }
        public decimal StokKgBirim { get; set; }
        public DateTime AlisTarihi { get; set; } = DateTime.Now;

    }
}
