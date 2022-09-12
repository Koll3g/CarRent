using CarRent.Common.Domain;

namespace CarRent.Rent.Domain
{
    public class Contract : Entity
    {
        public Contract (Guid id, DateTime pickUpDate) : base(id) 
        {
            PickUpDate = pickUpDate;
        }

        public Contract(Guid id) : base(id)
        {
        }
        public DateTime PickUpDate { get; set; }
    }
}
