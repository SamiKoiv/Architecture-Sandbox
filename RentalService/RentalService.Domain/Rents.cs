using RentalService.Entities;

namespace RentalService.Domain
{
    public abstract class Rents
    {
        public abstract IEnumerable<Rent> GetRents();
    }
}