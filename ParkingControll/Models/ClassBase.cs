using ParkingControll.Models.Enums;

namespace ParkingControll.Models
{
    public abstract class ClassBase
    {
        public int Id { get; set; }

        public RecordStatus Status { get; set; }

        #region CTOR
        public ClassBase()
        {
            Status = RecordStatus.ACTIVE;
        }
        #endregion

        #region IsActive
        public RecordStatus IsActive()
        {
            return Status;
        }
        #endregion
    }
}
