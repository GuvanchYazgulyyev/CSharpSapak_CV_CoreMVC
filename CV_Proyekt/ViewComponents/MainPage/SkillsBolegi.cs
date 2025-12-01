using Microsoft.AspNetCore.Mvc;
using CV_Proyekt.Models.SqlModels;
using System.Linq;
    
    
    namespace CV_Proyekt.ViewComponents.MainPage
{

    public class SkillsBolegi : ViewComponent
    {
        private readonly Context _context;

        public SkillsBolegi(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Fetch all skills
            var technicalSkills = _context.Skill
                .Where(s => s.Type == "Technical") // Assuming you filter by a 'Type' property
                .ToList();

            // Pass the list to the component's view
            return View(technicalSkills);
        }
    }
}
