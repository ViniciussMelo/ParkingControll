using ParkingControll.Services;
using System;

namespace ParkingControll.Models
{
    public class Parking : ClassBase
    {
        private double _price;

        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }
        
        public double Price
        {
            get { return _price; }
            set
            {
                this._price = Amount();
            }
        }

        #region CTOR
        public Parking()
        {
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
