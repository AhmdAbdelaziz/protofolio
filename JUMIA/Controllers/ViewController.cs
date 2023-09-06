using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
