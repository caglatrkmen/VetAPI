using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VeterinerAPI.Entities;

namespace VeterinerAPI.Data
{
    public class EfEntityRepositoryBase<PEntity, PContext> : IEntityRepository<PEntity>
        where PEntity : class , IEntity, new()
        where PContext : DbContext, new()
    {
      
        public PEntity Get(Expression<Func<PEntity, bool>> filter)
        {
            using (var context = new PContext())
            {
                return context.Set<PEntity>().SingleOrDefault(filter);

            }
        }

        public List<PEntity> GetList(Expression<Func<PEntity, bool>> filter = null)
        {
            using (var context = new PContext())
            {
                return filter == null
                    ? context.Set<PEntity>().ToList()
                    : context.Set<PEntity>().Where(filter).ToList();

            }
        }

        public void Add(PEntity entity)
        {
            using (var context = new PContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(PEntity entity)
        {
            using (var context = new PContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(PEntity entity)
        {
            using (var context = new PContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
