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
        public virtual DbSet<Stoklar> Stoklars { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Firmalar> Firmalars { get; set; }
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<Avanslar> Avanslars { get; set; }
        //public virtual DbSet<Odemeler> Odemelers { get; set; }
        public virtual DbSet<Izinler> Izinlers { get; set; }
        public virtual DbSet<Maaslar> Maaslars { get; set; }
        public virtual DbSet<SirketBilgiTB> Sirkets { get; set; }
        public virtual DbSet<Kasalar> Kasalars { get; set; }

        public virtual DbSet<Yemekler> Yemekler { get; set; }
        public virtual DbSet<Malzeme> Malzemeler { get; set; }
        public virtual DbSet<Siparisler> Siparisler { get; set; }

        public virtual DbSet<SiparisOdeme> SiparisOdeme { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
        }
    }
}
