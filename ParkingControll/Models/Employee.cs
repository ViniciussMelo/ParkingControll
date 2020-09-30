namespace ParkingControll.Models
{
    public class Employee : ClassBase
    {
        public string Name { get; set; }
        public string Email { get; set; }

        #region CTOR
        public Employee()
        {

        }

        public Employee(int id, string name, string email) : base(id)
        {
            Name = name;
            Email = email;
        }
        #endregion
    }
}
