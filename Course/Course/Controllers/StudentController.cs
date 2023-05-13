using Course.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student();
            {

            }
            return View();
        }
    }
}
