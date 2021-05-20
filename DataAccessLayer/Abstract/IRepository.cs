using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
     public interface IRepository<T>
    {
        List<T> List();
        void Update(T vrb_t);
        void Delete(T vrb_t);
        void Insert(T vrb_t);
        T Get(Expression<Func<T, bool>> filter);
        List<T> List(Expression<Func<T,bool>> filter);
  
    }
}
