namespace RentalService.Entities
{
    public abstract class User
    {
        public abstract string Name { get; }
        public abstract IEnumerable<Rent> Rents { get; }
    }
}
