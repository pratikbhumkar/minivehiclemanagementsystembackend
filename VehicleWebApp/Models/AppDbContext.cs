using Microsoft.EntityFrameworkCore;

namespace VehicleManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){ }
        public DbSet<Car> Car { get; set; }
    }
}
