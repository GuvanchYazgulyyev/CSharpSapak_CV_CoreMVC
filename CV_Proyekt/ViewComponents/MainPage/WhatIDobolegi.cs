using CV_Proyekt.Models.SqlModels;
using Microsoft.AspNetCore.Mvc;

namespace CV_Proyekt.ViewComponents.MainPage
{
    public class WhatIDoBolegi : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var getData = context.WhatIdos.ToList();
            return View(getData);
        }
    }
}