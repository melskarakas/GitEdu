using Microsoft.AspNetCore.Mvc;

namespace APP.UI.WEB.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
