using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        DbSet<Category> _object;

        public void Delete(Category vrb_category)
        {
            _object.Remove(vrb_category);
            context.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category vrb_category)
        {
            _object.Add(vrb_category);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
          
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category vrb_category)
        {
            context.SaveChanges();
        }
    }
}
