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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomdal)
        {
            _roomDal = roomdal;
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room TGetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public List<Room> TGetLİst()
        {
            return _roomDal.GetLİst();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
           
        }
    }
}
