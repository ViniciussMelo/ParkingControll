namespace ParkingControll.Models
{
    public class Employee : ClassBase
    {
        public string Name { get; set; }
        public string Email { get; set; }

        #region CTOR
        public Employee(string name, string email)
        {
            Name = name;
            Email = email;
        }
        #endregion
    }
}
