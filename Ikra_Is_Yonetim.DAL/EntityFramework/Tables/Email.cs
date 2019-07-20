using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Tables
{
    [Table("Emai",Schema ="IkraGenel")]
    public class Email
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string EmailAddres { get; set; }
        public string Port { get; set; }
        public string Host { get; set; }
        public string Password { get; set; }
    }
}
