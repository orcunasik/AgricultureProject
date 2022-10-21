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
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> GetListAll()
        {
            return _adminDal.GetListAll();
        }

        public void Insert(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
