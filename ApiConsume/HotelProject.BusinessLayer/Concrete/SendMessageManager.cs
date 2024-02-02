using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage entity)
        {
            _sendMessageDal.Delete(entity);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendMessageDal.GetByID(id);
        }

        public List<SendMessage> TGetLİst()
        {
            return _sendMessageDal.GetLİst();
        }

        public void TInsert(SendMessage entity)
        {
            _sendMessageDal.Insert(entity);
        }

        public void TUpdate(SendMessage entity)
        {
            _sendMessageDal.Update(entity);
        }
    }
}
