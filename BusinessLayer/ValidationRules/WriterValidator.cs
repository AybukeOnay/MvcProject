using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş bırakılamaz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("50 karakterden fazla değer girişi yapmayınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmı boş bırakılamaz");
            RuleFor(x => x.WriterAbout).Matches("a").WithMessage("Hakkımda kısmında içinde a geçmesi zorunludur");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan boş geçilemez");

        }
    }
}
