namespace RentalService.Entities
{
    public abstract class Item
    {
        public abstract string Name { get; }

        public abstract IEnumerable<Rent> Rents { get; }
    }
}