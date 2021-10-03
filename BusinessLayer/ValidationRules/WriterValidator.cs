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
            RuleFor(x => x.WriterPassword).Matches("[a-z]").WithMessage("Şifrede en az bir tane küçük harf yer almalıdır.");
            RuleFor(x => x.WriterPassword).Matches("[A-Z]").WithMessage("Şifrede en az bir tane büyük harf yer almalıdır.");
            RuleFor(x => x.WriterPassword).Matches("[0-9]").WithMessage("Şifrede en az bir tane rakam yer almalıdır.");
            RuleFor(x => x.WriterPassword).Equal(x => x.WriterPasswordConfirm).WithMessage("Girdiğiniz şifreler eşleşmiyor");
            RuleFor(x => x.WriterPasswordConfirm).NotEmpty().WithMessage("Şifre (Tekrar) boş geçilemez");
            RuleFor(x=>x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x=>x.WriterName).MaximumLength(50).WithMessage("Lütfen fazla 50 karakterlik girişi yapınız");
            RuleFor(x => x.WriterAgreement).NotEmpty().WithMessage("Kullanıcı sözleşmesi onaylanmadı.");
         //   RuleFor(x => x.WriterCityID).NotEmpty().WithMessage("Kullanıcı şehri boş geçilemez");
        }

    }
}
