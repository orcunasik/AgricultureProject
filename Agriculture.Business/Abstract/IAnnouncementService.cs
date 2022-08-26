using Agriculture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Business.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void AnnouncementStatus(int id);
    }
}
