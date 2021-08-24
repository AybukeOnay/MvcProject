using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendbox(string p);
        void MessageAddBL(Message message);
        Message GetByID(int id);
        void MessageDeleteBL(Message message);
        void MessageUpdateBL(Message message);
        List<Message> GetReadList(string session);
        List<Message> GetUnReadList(string session);
        List<Message> IsDraft(string session);
        List<Message> GetListDraft(string session);
        List<Message> GetListTrash();
        List<Message> GetListSpam(string session);
        List<Message> GetListImportant(string session);
    }
}
