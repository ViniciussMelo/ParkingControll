using ParkingControll.Models.Enums;

namespace ParkingControll.Models
{
    public class Vehicle : ClassBase
    {
        public string LicensePlate { get; set; }
        public CarModel CarModel { get; set; }

        #region CTOR
        public Vehicle()
        {

        }

        public Vehicle(int id, string licensePlate, CarModel carModel) : base(id)
        {
            LicensePlate = licensePlate;
            CarModel = carModel;
        }
        #endregion
    }
}