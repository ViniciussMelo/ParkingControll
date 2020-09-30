using ParkingControll.Services;
using System;

namespace ParkingControll.Models
{
    public class Parking : ClassBase
    {
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }

        public double Price { get; private set; }

        #region CTOR
        public Parking()
        {

        }

        public Parking(int id, DateTime initialDate, DateTime finalDate, Vehicle vehicle, Employee employee) : base(id)
        {
            InitialDate = initialDate;
            FinalDate = finalDate;
            Vehicle = vehicle;
            Employee = employee;
            Price = Amount();
        }
        #endregion

        #region Amount
        private double Amount()
        {
            TimeSpan totalHours = FinalDate.Subtract(InitialDate);

            return AmountService.TotalPrice(totalHours.Hours);
        }
        #endregion
    }
}
