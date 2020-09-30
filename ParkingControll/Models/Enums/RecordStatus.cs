using System.ComponentModel.DataAnnotations;

namespace ParkingControll.Models.Enums
{
    public enum RecordStatus : int
    {
        [Display(Name = "Inactive")]
        INATIVE = 0,
        [Display(Name = "Active")]
        ACTIVE = 1
    }
}
