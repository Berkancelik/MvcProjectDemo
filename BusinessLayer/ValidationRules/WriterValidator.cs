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
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Açıklmayaı Boş Geçemezsiniz");
            RuleFor(x => x.About).NotEmpty().WithMessage("Hakkımda Kısmını Geçemezsiniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla veri girişi yapmayınız");
        }

    }
}
