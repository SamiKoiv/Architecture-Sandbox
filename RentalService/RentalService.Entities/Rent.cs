namespace RentalService.Entities
{
    public abstract class Rent
    {
        public abstract User User { get; }
        public abstract Item Item { get; }
        public abstract DateTime IssuedDate { get; }
        public abstract DateTime DueDate { get; }
    }
}
