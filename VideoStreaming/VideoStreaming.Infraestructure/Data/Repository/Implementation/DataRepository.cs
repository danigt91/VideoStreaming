using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Entity.Contract;
using VideoStreaming.Infraestructure.Data.Repository.Contract;

namespace VideoStreaming.Infraestructure.Data.Repository.Implementation
{
    abstract class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : EntityBase
    {
        protected IUnitOfWork<IContext> context
        {
            get; set;
        }

        public DataRepository(IUnitOfWork<IContext> _contexto)
        {
            _contexto = context;
        }

        public DbSet<TEntity> Set()
        {
            return context.Set(typeof(TEntity)).Cast<TEntity>();
        }

        public IQueryable<TEntity> All()
        {
            return Set().AsQueryable();
        }

        public TEntity Find(Guid id)
        {
            return Set().Find(id);
        }

        public TEntity Create(TEntity entity)
        {
            context.Entry(entity).Cast<TEntity>().State = EntityState.Added;
            context.Save();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            context.Entry(entity).Cast<TEntity>().State = EntityState.Modified;
            context.Save();
            return entity;
        }

        public TEntity Remove(TEntity entity)
        {
            context.Entry(entity).Cast<TEntity>().State = EntityState.Deleted;
            context.Save();
            return entity;
        }


    }
}
