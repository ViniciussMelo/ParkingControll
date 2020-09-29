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
    }
}
