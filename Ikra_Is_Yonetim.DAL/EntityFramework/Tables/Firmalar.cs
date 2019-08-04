using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("FirmalarTB",Schema ="IkraDesk")]
    public class Firmalar
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string YetkiliKisi { get; set; }
    }
}
