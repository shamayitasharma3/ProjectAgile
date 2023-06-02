
using Agile_Project_Management_Portal.DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace Agile_Project_Management_Portal.DAL.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Defect> Defects { get; set; }

        public DbSet<Resolution> Resolutions { get; set; }


    }
}
