namespace RentalService.Entities
{
    public abstract class User
    {
        public string Name { get; }
        public IEnumerable<Rent> Rents { get; }
    }
}
