 using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        //public async Task<IActionResult> Index(Writer p)
        public async Task<Boolean> Index(Writer p)
        {
            Context c = new Context();
            var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail &&
            x.WriterPassword == p.WriterPassword);
            if (dataValue != null)
            {
                //HttpContext.Session.SetString("username", p.WriterMail);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email,p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return true;
                //return RedirectToAction("Index", "Writer");
            }
            else
            {
                //return View();
                return false;
            }


        }
    }
}
