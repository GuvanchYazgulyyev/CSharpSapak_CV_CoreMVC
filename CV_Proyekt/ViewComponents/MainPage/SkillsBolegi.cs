using Microsoft.AspNetCore.Mvc;
using CV_Proyekt.Models.SqlModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CV_Proyekt.ViewComponents.MainPage
{
    public class SkillsBolegi : ViewComponent
    {
        // NOTE: The constructor that required Context dependency injection is removed.

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Manually instantiate the Context since it is not being injected.
            // The 'using' statement ensures the context object is properly disposed of.
            using (var _context = new Context())
            {
                var allSkills = await _context.Skills
                                              .Where(s => s.Type != null)
                                              .ToListAsync();

                // Group the skills by their Type property (e.g., "Technical" or "Professional")
                var groupedSkills = allSkills.GroupBy(s => s.Type)
                                             .OrderBy(g => g.Key);

                return View(groupedSkills);
            }
        }
    }
}