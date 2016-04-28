using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data.Contract;

namespace VideoStreaming.Infraestructure.Data.Repository.Contract
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : IContext
    {

        void Save();

        DbSet Set(Type t);

        DbEntityEntry Entry(object entity);

    }
}
