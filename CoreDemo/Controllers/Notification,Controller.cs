using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class Notification_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
