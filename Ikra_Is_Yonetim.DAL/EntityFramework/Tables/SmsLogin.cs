using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("SmsPass",Schema ="IkraWeb")]
    public class SmsLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        //Cariye ait telefona gönderildiğini belirtir.
        public string Phone { get; set; }
        public string Code { get; set; }
        //Giriş yaptıktan sonra bu alan false olarak işaretlenir.
        public bool isVerified { get; set; } = true;
    }
}
