using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsini!!");
            RuleFor(x => x.CategoryContent).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen Kategori Başlığını En Az 3 Karakter Giriniz.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen Kategori Başlığını En Fazla 50 Karakter Giriniz.");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Başlığını Giriniz.");
        }
    }
}
