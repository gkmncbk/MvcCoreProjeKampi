using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class NewsLetterValidator : AbstractValidator<NewsLetter>
    {
        public NewsLetterValidator()
        {
            RuleFor(s => s.Mail).NotEmpty().WithMessage("Mail adresi boş geçilemez")
                                 .EmailAddress().WithMessage("Geçersiz bir mail adresi girildi");
        }

    }
}
