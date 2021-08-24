using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AdminAddBL(Admin admin);
        Admin GetByID(int id);
        void AdminDeleteBL(Admin admin);
        void AdminUpdateBL(Admin admin);
    }
}
