﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashbord:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterByID(1);
            return View(values);
        }
    }
}
