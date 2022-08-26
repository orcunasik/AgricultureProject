using Agriculture.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Business.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(a => a.Title).NotEmpty().WithMessage("Son Gelişmeler Başlık Alanı Boş Geçilemez!");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Son Gelişmeler Açıklamalar Boş Geçilemez!");
            RuleFor(a => a.ImageUrl).NotEmpty().WithMessage("Son Gelişmeler Görsel Ekleyiniz!");
        }
    }
}
