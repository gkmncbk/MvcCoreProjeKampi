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
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x=>x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x=>x.WriterName).MaximumLength(50).WithMessage("Lütfen fazla 50 karakterlik girişi yapınız");
            //RuleFor(x => x.WriterPassword).Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter, en az bir harf ve bir sayı içermelidir!");
        }
        //private bool IsPasswordValid(string arg)
        //{
        //    Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]$");
        //    return regex.IsMatch(arg);
        //}
    }
}
