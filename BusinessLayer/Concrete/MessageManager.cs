using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListDraft(string session)
        {
            return _messageDal.List(x => x.IsDraft == true && x.SenderMail == session);
        }

        public List<Message> GetListImportant(string session)
        {
            return _messageDal.List(x => x.IsImportant == true && x.ReceiverMail == session);
        }

        public List<Message> GetListInbox(string p)
        {
            return _messageDal.List(x => x.ReceiverMail == "admin2@gmail.com");
        }

        public List<Message> GetListSendbox(string p)
        {
            return _messageDal.List(x => x.SenderMail == "admin2@gmail.com");
        }

        public List<Message> GetListSpam(string session)
        {
            return _messageDal.List(x => x.IsSpam == true );
        }

        public List<Message> GetListTrash()
        {
            return _messageDal.List(x => x.Trash == true);
        }

        public List<Message> GetReadList(string session)
        {
            return _messageDal.List(x => x.IsRead == true);
        }

        public List<Message> GetUnReadList(string session)
        {
            return _messageDal.List(x => x.ReceiverMail == "admin2@gmail.com");
        }

        public List<Message> IsDraft(string session)
        {
            return _messageDal.List(x => x.IsDraft == true);
        }

        public void MessageAddBL(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDeleteBL(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdateBL(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
