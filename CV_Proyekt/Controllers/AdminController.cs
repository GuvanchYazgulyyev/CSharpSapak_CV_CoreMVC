using CV_Proyekt.Models.SqlModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CV_Proyekt.Controllers
{
    public class AdminController : Controller
    {


        private readonly Context _db;

        public AdminController(Context db)
        {
            _db = db;
        }
        // --- 1. Admin Dashboard(Index) ---
        public IActionResult Index()
        {
            return View();
        }
        // --- 2. Example CRUD Actions (for the AboutMes table) ---

        public async Task<IActionResult> AboutList()
        {
            var data = await _db.AboutMes.ToListAsync();
            return View(data);


        }
        // B. ADD (Create - HTTP GET for Form)
        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }

        // C. ADD (Create - HTTP POST for Submission)
        public async Task<IActionResult> AboutAdd(AboutMe model)
        {
            if (ModelState.IsValid)
            {
                _db.AboutMes.Add(model);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(AboutList));

            }
            return View(model);


        }
    }
}
