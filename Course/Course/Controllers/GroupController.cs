using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }

    public IActionResult Detail()
    {
        return View();
    }
}
