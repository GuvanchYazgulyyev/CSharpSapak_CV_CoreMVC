using CV_Proyekt.Models.SqlModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CV_Proyekt.ViewComponents.MainPage
{
    public class AboutBolegi : ViewComponent
    {
        private Context dr = new Context();
        public IViewComponentResult Invoke()
        {
            var getData = dr.TagSkills.OrderByDescending(f => f.Id).ToList();
            return View(getData);
        }
    }
}
