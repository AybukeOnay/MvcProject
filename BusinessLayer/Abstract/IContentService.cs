using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetList(string vrb_word);
        List<Content> GetListByHeadingID(int id);
        List<Content> GetListByWriter(int id);
        void ContentAddBL(Content content);
        Category GetByID(int id);
        void ContentDeleteBL(Content content);
        void ContentUpdateBL(Content content);
    }
}
