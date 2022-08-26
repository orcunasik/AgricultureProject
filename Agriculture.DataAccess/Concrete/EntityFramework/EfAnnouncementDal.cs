using Agriculture.DataAccess.Abstract;
using Agriculture.DataAccess.Concrete.Repository;
using Agriculture.DataAccess.Contexts;
using Agriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.DataAccess.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AnnouncementStatus(int id)
        {
            using var context = new AgricultureContext();
            var announcementStatus = context.Announcements.Find(id);
            if (announcementStatus.Status == true)
            {
                announcementStatus.Status = false;
                context.SaveChanges();
            }
            else
            {
                announcementStatus.Status = true;
                context.SaveChanges();
            }
        }

    }
}
