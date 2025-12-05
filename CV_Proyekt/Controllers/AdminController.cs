using Microsoft.AspNetCore.Mvc;

namespace CV_Proyekt.Controllers
{
    public class AdminController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
