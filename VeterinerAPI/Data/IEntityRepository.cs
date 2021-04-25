using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VeterinerAPI.Entities;

namespace VeterinerAPI.Data
{
    public interface IEntityRepository<P> where P : class, IEntity, new() 
    {
        P Get(Expression<Func<P, bool>> filter = null);

        List<P> GetList(Expression<Func<P, bool>> filter = null);

        void Add(P Entity);

        void Update(P Entity);

        void Delete(P Entity);
    }
}
