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

            ViewBag.Citys = new List<CityViewModel>
                            {
                                new CityViewModel() {CityID = 1, CityName = "Ankara"},
                                new CityViewModel() {CityID = 2, CityName = "İstanbul"},
                                new CityViewModel() {CityID = 3, CityName = "İzmir"},
                                new CityViewModel() {CityID = 4, CityName = "Bursa"}
                                                                                        }.Select(i => new SelectListItem()
                                                                                        {
                                                                                            Text = i.CityName,
                                                                                            Value = i.CityID.ToString(),
                                                                                            
                                                                                        });
             List<Country> CountriesTable = Country.GetFakeCountries();
            ViewBag.CountriesData = new SelectList(CountriesTable, "WriterCityID", "CountryName");
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
