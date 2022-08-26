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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void Insert(Announcement announcement)
        {
            _announcementDal.Insert(announcement);
        }

        public void Update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
        }
    }
}
