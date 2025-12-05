using CV_Proyekt.Models.SqlModels;
using Microsoft.AspNetCore.Mvc;

namespace CV_Proyekt.Controllers
{
    public class LoginController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public async Task<IActionResult> Girish( )
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Girish(LoginDto loginDto )
        {
            var checkData = db.Admins.FirstOrDefault(f => f.PhoneNumber == loginDto.telNo && f.Password == loginDto.psw);
            return View();
        }

        public class LoginDto
        {
            public string telNo {  get; set; }
            public string psw { get; set; }
        }
    }
}
