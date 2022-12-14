using Agriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.DataAccess.Abstract
{
    public interface IAnnouncementDal : IGenericDal<Announcement>
    {
        void AnnouncementStatus(int id);
    }
}
