using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.EntityFramework.Context
{
    public class IkraContext:DbContext
    {
        public IkraContext():base("name=IkraDB")
        {

        }
        public virtual DbSet<Kullanicilar> Kullanicilars{ get; set; }      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
