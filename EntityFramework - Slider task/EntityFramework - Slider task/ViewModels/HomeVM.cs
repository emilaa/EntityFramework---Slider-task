using EntityFramework___Slider_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework___Slider_task.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }
    }
}
