﻿using Microsoft.EntityFrameworkCore;
using WBL_EF_CORE.Abstract;
using WBL_EF_CORE.Models;
using WBL_EF_CORE.Models.Abstract;

namespace WBL_EF_CORE.Concrete
{
    public class BaseRepoitory<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : BaseEntity,IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry((entity));
                addedEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry((entity));
                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry((entity));
                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
