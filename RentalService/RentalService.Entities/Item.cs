namespace RentalService.Entities
{
    public abstract class Item
    {
        public string Name { get; }

        public IEnumerable<Rent> Rents { get; }
    }
}