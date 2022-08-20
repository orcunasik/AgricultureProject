using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.DataAccess.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class, new()
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetListAll();
    }
}
