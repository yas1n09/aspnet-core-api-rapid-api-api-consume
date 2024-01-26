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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetLİst()
        {
            return _contactDal.GetLİst();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
