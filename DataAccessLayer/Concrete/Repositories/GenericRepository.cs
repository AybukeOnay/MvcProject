using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }             
        public void Delete(T vrb_t)
        {
            var deletedEntity = context.Entry(vrb_t);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(vrb_t);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T vrb_t)
        {
            var addedEntity = context.Entry(vrb_t);
            addedEntity.State = EntityState.Added;
            //_object.Add(vrb_t);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T vrb_t)
        {
            var updatedEntity = context.Entry(vrb_t);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
