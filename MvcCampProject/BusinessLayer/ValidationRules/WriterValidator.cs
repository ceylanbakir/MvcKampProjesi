using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Yazar Adını Soyadını Adını Boş Geçemezsini!!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımızda alanını boş geçemezsiniz");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage("Lütfen Yazarın Ad ve Soyadını En Az 2 Karakter Giriniz.");
            RuleFor(x => x.NameSurname).MaximumLength(200).WithMessage("Lütfen Kategori Başlığını En Fazla 200 Karakter Giriniz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen Maili Giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen Şifreyi Giriniz.");
        }
    }
}
