namespace RentalService.NonPersistingDataAccess.Models
{
    public class User : UseCases.Models.User
    {
        internal Guid Id { get; set; }
        public override string Name { get; }
        public override IEnumerable<Entities.Rent> Rents { get; }

        public User(string name)
        {
            Name = name;
            Rents = new List<Entities.Rent>();
        }
    }
}
