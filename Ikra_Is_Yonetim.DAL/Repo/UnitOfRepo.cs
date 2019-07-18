﻿using Ikra_Is_Yonetim.DAL.EntityFramework.Context;
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
        public EFRepo<Kullanicilar> kullaniciRepository
        {
            get
            {
                return this.kullaniciRepo ?? new EFRepo<Kullanicilar>(context);
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