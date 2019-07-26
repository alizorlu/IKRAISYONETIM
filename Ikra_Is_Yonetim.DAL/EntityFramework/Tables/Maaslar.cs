using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("PersonelMaaslarTB", Schema = "IkraDesk")]
    public class Maaslar
    {
        public Guid Id { get; set; }
        public bool Odendi { get; set; } = false;

        [ForeignKey("Personel")]
        public Guid PersonelId { get; set; }
        public virtual Personeller Personel { get; set; }
        public decimal OdemeTutari { get; set; }
        public DateTime SonMaasDonemTarihi { get; set; }
        public string FaturaId { get; set; }
    }
}
