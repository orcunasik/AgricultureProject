using Agriculture.Business.Abstract;
using Agriculture.DataAccess.Abstract;
using Agriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void Delete(Address address)
        {
            _addressDal.Delete(address);
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Address> GetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void Insert(Address address)
        {
            _addressDal.Insert(address);
        }

        public void Update(Address address)
        {
            _addressDal.Update(address);
        }
    }
}
