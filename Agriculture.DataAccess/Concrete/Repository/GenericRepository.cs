using Agriculture.DataAccess.Abstract;
using Agriculture.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.DataAccess.Concrete.Repository
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, new()
    {
        public void Delete(TEntity entity)
        {
            using var context = new AgricultureContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            using var context = new AgricultureContext();
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetListAll()
        {
            using var context = new AgricultureContext();
            return context.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            using var context = new AgricultureContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new AgricultureContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
