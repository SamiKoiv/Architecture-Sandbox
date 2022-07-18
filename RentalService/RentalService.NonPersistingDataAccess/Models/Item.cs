using RentalService.UseCases.Models;

namespace RentalService.NonPersistingDataAccess.Models
{
    public class Item : UseCases.Models.Item
    {
        internal Guid Id { get; set; }

        public override string Name { get; }

        public override IEnumerable<Entities.Rent> Rents { get; }

        public Item(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Rents = new List<Entities.Rent>();
        }

    }
}