using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Repository.Contract;

namespace VideoStreaming.Infraestructure.Data.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork<IContext>
    {

        private IContext context;

        public UnitOfWork(IContext _context)
        {
            context = _context;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public DbSet Set(Type t)
        {
            return context.Set(t);
        }

        public DbEntityEntry Entry(object entity)
        {
            return context.Entry(entity);
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
