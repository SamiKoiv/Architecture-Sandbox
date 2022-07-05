namespace RentalService.Entities
{
    public abstract class Rent
    {
        public User User { get; }
        public Item Item { get; }
        public DateTime IssuedDate { get; }
        public DateTime DueDate { get; }
    }
}
