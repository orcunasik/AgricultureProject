using Agriculture.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Business.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().WithMessage("Personel Adı Boş Geçilemez!");
            RuleFor(e => e.LastName).NotEmpty().WithMessage("Personel Soyadı Boş Geçilemez!");
            RuleFor(e => e.Job).NotEmpty().WithMessage("Meslek Alanı Boş Geçilemez!");
            RuleFor(e => e.ImageUrl).NotEmpty().WithMessage("Personel Avatar Görseli Boş Geçilemez!");
            RuleFor(e => e.FirstName).MinimumLength(2).WithMessage("Personel Adı En Az 2 Karakter Olmalıdır!");
            RuleFor(e => e.FirstName).MaximumLength(40).WithMessage("Personel Adı En Fazla 40 Karakter Olmalıdır!");
            RuleFor(e => e.LastName).MinimumLength(2).WithMessage("Personel Soyadı En Az 2 Karakter Olmalıdır!");
            RuleFor(e => e.LastName).MaximumLength(25).WithMessage("Personel Soyadı En Fazla 25 Karakter Olmalıdır!");
            RuleFor(e => e.Job).MinimumLength(5).WithMessage("Meslek Alanı En Az 5 Karakter Olmalıdır!");
            RuleFor(e => e.Job).MaximumLength(30).WithMessage("Meslek Alanı En Fazla 30 Karakter Olmalıdır!");
        }
    }
}
