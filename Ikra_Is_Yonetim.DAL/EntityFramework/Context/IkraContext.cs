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
        public virtual DbSet<Uretim> Uretims { get; set; }
        public virtual DbSet<UretimCikislar> Siparisler { get; set; }
        public virtual DbSet<UretimMalzemeler> UretimMalzemelers { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<Avanslar> Avanslars { get; set; }
        //public virtual DbSet<Odemeler> Odemelers { get; set; }
        public virtual DbSet<Izinler> Izinlers { get; set; }
        public virtual DbSet<Maaslar> Maaslars { get; set; }
        public virtual DbSet<SirketBilgiTB> Sirkets { get; set; }
        public virtual DbSet<Kasalar> Kasalars { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uretim>()
                .Property(i => i.BirimFiyat1)
                
                .HasColumnType("Money");
        }
    }
}
