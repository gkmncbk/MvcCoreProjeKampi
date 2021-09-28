using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryCount : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var value = bm.GetBlogListWithCategory(id);
            ViewBag.CategoryCount = value.Count();
            return View();
        }
    }
}
