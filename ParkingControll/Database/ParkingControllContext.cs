using Microsoft.EntityFrameworkCore;

namespace ParkingControll.Models
{
    public class ParkingControllContext : DbContext
    {
        #region CTOR
        public ParkingControllContext(DbContextOptions<ParkingControllContext> options) : base(options)
        {
        }
        #endregion

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Parking> Parking { get; set; }
    }
}
