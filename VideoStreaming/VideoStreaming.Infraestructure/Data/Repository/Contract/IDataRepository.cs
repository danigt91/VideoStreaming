using System;
using System.Data.Entity;
using System.Linq;
using VideoStreaming.Infraestructure.Data.Entity.Contract;

namespace VideoStreaming.Infraestructure.Data.Repository.Contract
{
    public interface IDataRepository<TEntity> where TEntity : EntityBase
    {

        DbSet<TEntity> Set();

        IQueryable<TEntity> All();

        TEntity Find(Guid id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Remove(TEntity entity);

    }
}
