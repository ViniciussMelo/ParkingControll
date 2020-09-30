using ParkingControll.Models.Enums;

namespace ParkingControll.Models
{
    public abstract class ClassBase
    {
        public int Id { get; set; }

        public RecordStatus Status { get; set; }

        #region CTOR
        protected ClassBase()
        {

        }

        public ClassBase(int id)
        {
            Id = id;
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
