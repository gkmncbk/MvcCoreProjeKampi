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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public List<string> PartialAddComment(Comment p)
        {
            List<string> Hatalar;
            //p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //p.CommentStatus = true;
            ////p.BlogID = 2;
            //cm.CommentAdd(p);
            CommentValidator wv = new CommentValidator();
            ValidationResult result = wv.Validate(p);
            if (result.IsValid)
            {
                p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.CommentStatus = true;
                //p.BlogID = 2;
                cm.CommentAdd(p);
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
            




            //return RedirectToAction("Index", "Blog");
            //return Json(p);
        }
        //[HttpPost]
        //public IActionResult PartialAddComment(Comment p)
        //{
        //    p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
        //    p.CommentStatus = true;
        //    p.BlogID = 2;
        //    cm.CommentAdd(p);          
        //    //return RedirectToAction("Index", "Blog");
        //    return Json(p);
        //}
        public PartialViewResult CommentListByBlog(int id)
        {
           var values= cm.GetList(id);
            return PartialView(values);
        }
    }
}
