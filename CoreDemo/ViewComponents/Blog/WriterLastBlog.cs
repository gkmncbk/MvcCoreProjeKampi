using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        //public IViewComponentResult Invoke(int WriterID, int BlogID)
        //{
        //    var value = bm.GetBlogOtherListWriter( WriterID,  BlogID);
        //    return View(value);
        //}
        public IViewComponentResult Invoke()
        {
            
            var value = bm.GetBlogListWriter(1);
            return View(value);
        }
    }
}
