using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAddBL(Category category);
        Category GetByID(int id);
        void CategoryDeleteBL(Category category);
        void CategoryUpdateBL(Category category);
    }
}
