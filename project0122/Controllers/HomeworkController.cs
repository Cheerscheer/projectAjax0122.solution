using Microsoft.AspNetCore.Mvc;

namespace project0122.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
