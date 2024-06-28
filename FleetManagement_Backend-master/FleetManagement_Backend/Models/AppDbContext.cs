using Microsoft.EntityFrameworkCore;


namespace FleetManagement_Backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            
        }
        public DbSet<State> State  { get; set; } // name of table created inside database
        public DbSet<City> City { get; set; }
        public DbSet<Hubs> Hubs { get; set; }
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarCategory> Car_category { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<AddOn> AddOn { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Billing> Billings { get; set; }
    }
}
