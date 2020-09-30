using ParkingControll.Models;
using ParkingControll.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingControll.Database
{
    public class SeedingService
    {
        private ParkingControllContext _context;

        #region CTOR
        public SeedingService(ParkingControllContext context)
        {
            _context = context;
        }
        #endregion

        #region Seed
        public void Seed()
        {
            if (_context.Employee.Any() ||
                _context.Vehicle.Any() ||
                _context.Parking.Any())
            {
                return;
            }

            Employee emp1 = new Employee(1, "Vinicius", "vinicius@email.com");
            Employee emp2 = new Employee(2, "Wesley", "wesley@email.com");

            Vehicle vehicle1 = new Vehicle(1, "abc123", CarModel.Gol);
            Vehicle vehicle2 = new Vehicle(2, "bac321", CarModel.Fox);
            Vehicle vehicle3 = new Vehicle(3, "cba131", CarModel.Saveiro);
            Vehicle vehicle4 = new Vehicle(4, "cbc123", CarModel.Duster);

            Parking parking1 = new Parking(1, DateTime.Now, DateTime.Now.AddHours(1), vehicle1, emp1);
            Parking parking2 = new Parking(2, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(2), vehicle1, emp1);
            Parking parking3 = new Parking(3, DateTime.Now, DateTime.Now.AddHours(3), vehicle2, emp1);
            Parking parking4 = new Parking(4, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(1), vehicle2, emp1);
            Parking parking5 = new Parking(5, DateTime.Now.AddHours(2), DateTime.Now.AddHours(2).AddMinutes(30), vehicle3, emp2);
            Parking parking6 = new Parking(6, DateTime.Now, DateTime.Now.AddHours(1), vehicle3, emp2);

            _context.Employee.AddRange(emp1, emp2);
            _context.Vehicle.AddRange(vehicle1, vehicle2, vehicle3, vehicle4);
            _context.Parking.AddRange(parking1, parking2, parking3, parking4, parking5, parking6);

            _context.SaveChanges();
        }
        #endregion
    }
}
