using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Entity.Contract;

namespace VideoStreaming.Infraestructure.Data.Repository.Contract
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : IContext
    {

        void Save();

        DbSet<TEntity> Set<TEntity>() where TEntity : EntityBase;

        DbEntityEntry Entry(object entity);

    }
}
