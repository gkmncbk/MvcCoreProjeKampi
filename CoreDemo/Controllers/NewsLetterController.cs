using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        { 
            return PartialView();
        }
        //[HttpPost]
        //public IActionResult SubscribeMail(NewsLetter p)
        //{
        //    p.MailStatus = true;
        //    nm.AddNewLetter(p);
        //    return Json(p);

        //}

        [HttpPost]
        public List<string>  SubscribeMail(NewsLetter p)
        {
            List<string> Hatalar;
            
           //p.MailStatus = true;
           //nm.AddNewLetter(p);
           NewsLetterValidator wv = new NewsLetterValidator();
            ValidationResult result = wv.Validate(p);
            if (result.IsValid)
            {
                p.MailStatus = true;
                nm.AddNewLetter(p);
                return null;
            }
            else
            {
                Hatalar = new List<string>();
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    Hatalar.Add(item.ErrorMessage);
                }
                return Hatalar;
            }
          

            //if (!String.IsNullOrEmpty(subs.Mail))
            //    //TODO: Save the data in database  
            //    return "Thank you " + subs.Mail + ". Record Saved.";
            //else
            //    return "Please complete the form.";
        }

    }
}
