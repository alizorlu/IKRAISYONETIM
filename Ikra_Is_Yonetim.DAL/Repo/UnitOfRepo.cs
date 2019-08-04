using Ikra_Is_Yonetim.DAL.EntityFramework.Context;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.DAL.Repo
{
    public class UnitOfRepo : IDisposable
    {
        private IkraContext context = new IkraContext();
        private EFRepo<Kullanicilar> kullaniciRepo;
        private EFRepo<Firmalar> firmaRepo;
        public EFRepo<Firmalar> firmaRepository
        {
            get
            {
                return this.firmaRepo ?? new EFRepo<Firmalar>(context);
            }
        }
        private EFRepo<Stoklar> stokRepo;
        public EFRepo<Stoklar> stokRepository
        {
            get
            {
                return this.stokRepo ?? new EFRepo<Stoklar>(context);
            }
        }
        private EFRepo<Kasalar> kasaRepo;
        public EFRepo<Kasalar> kasaRepository
        {
            get
            {
                return this.kasaRepo ?? new EFRepo<Kasalar>(context);
            }
        }
        public EFRepo<Kullanicilar> kullaniciRepository
        {
            get
            {
                return this.kullaniciRepo ?? new EFRepo<Kullanicilar>(context);
            }
        }
        private EFRepo<SirketBilgiTB> sirketRepo;
        public EFRepo<SirketBilgiTB> sirketRepository
        {
            get
            {
                return this.sirketRepo ?? new EFRepo<SirketBilgiTB>(context);
            }
        }
        private EFRepo<Avanslar> avansRepo;
        public EFRepo<Avanslar> avansRepository
        {
            get
            {
                return this.avansRepo ?? new EFRepo<Avanslar>(context);
            }
        }
        private EFRepo<Maaslar> maasRepo;
        public EFRepo<Maaslar> maasRepository
        {
            get
            {
                return this.maasRepo ?? new EFRepo<Maaslar>(context);
            }
        }
        private EFRepo<Izinler> izinlerRepo;
        public EFRepo<Izinler> izinlerRepository
        {
            get
            {
                return this.izinlerRepo ?? new EFRepo<Izinler>(context);
            }
        }
        private EFRepo<Personeller> personelRepo;
        public EFRepo<Personeller> personelRepository
        {
            get
            {
                return this.personelRepo ?? new EFRepo<Personeller>(context);
            }
        }
        private EFRepo<Email> emailRepo;
        public EFRepo<Email> emailRepository
        {
            get
            {
                return this.emailRepo ?? new EFRepo<Email>(context);
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public void Save(out bool issaved)
        {
            context.SaveChanges();
            issaved = true;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
