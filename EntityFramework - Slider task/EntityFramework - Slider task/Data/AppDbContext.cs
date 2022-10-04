using EntityFramework___Slider_task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework___Slider_task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
    }
}
