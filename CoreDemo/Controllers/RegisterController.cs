using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {

            List<CityViewModel> cwm = new List<CityViewModel>()
            {
                new CityViewModel
                {
                    CityID=1,
                    CityName="Ankara",
                    CityStatus=true
                },
                  new CityViewModel
                {
                    CityID=2,
                    CityName="İstanbul",
                    CityStatus=true
                },
                 new CityViewModel
                {
                    CityID=3,
                    CityName="İzmir",
                    CityStatus=true
                },
                  new CityViewModel
                {
                    CityID=4,
                    CityName="Konya",
                    CityStatus=true
                },
            };


            IEnumerable<SelectListItem> cm = cwm.ToList()
                                           .Select(i => new SelectListItem()
                                           {
                                               Text = i.CityName,
                                               Value = i.CityID.ToString()
                                           });

            ViewBag.Citys = cm;


            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(p);
            if (result.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }              
            }
            return View();
        }
    }
}
