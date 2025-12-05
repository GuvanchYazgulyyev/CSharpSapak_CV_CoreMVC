using CV_Proyekt.Models.SqlModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CV_Proyekt.Controllers
{
    public class VitrinController : Controller
    {
        Context db = new Context();
        private readonly ILogger _logger;
        public VitrinController(ILogger<VitrinController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var dataGetir = await db.AboutMeDatas.OrderByDescending(f => f.Id).AsNoTracking().ToListAsync();
            return View(dataGetir);
        }
       /// !!! TASK  Geljek sapaka  TAze Controller. Açmaly. Bu Controller Admin Tarapy üçindir!  21-11-2025
       /// We şol bir wagtda  Admin üçin Layout açmaly. 
       /// Controller için  CRUD işlemleri bolmaly. Controller içinde Dine Şuwagtlykça IActionRessultlar YAzylymaly.
       /// We Mumyn daşyn  Login - Register üçin Taze bir Controller açmaly. İçinde Parolymy Yatdayn çykardymi rEgister, Login  Actionlary bolmaly. 
       /// We Elbette. Data bazasyndaky Tablissalaryn hemmesine doly maglumat girmeli!!!
    }
}