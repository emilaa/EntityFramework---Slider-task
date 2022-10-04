using EntityFramework___Slider_task.Data;
using EntityFramework___Slider_task.Models;
using EntityFramework___Slider_task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework___Slider_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDetail sliderDetail = _context.SliderDetails.FirstOrDefault();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetail = sliderDetail
            };

            return View(model);
        }
    }
}
