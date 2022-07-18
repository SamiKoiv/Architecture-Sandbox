namespace RentalService.NonPersistingDataAccess.Models
{
    public class Rent : UseCases.Models.Rent
    {
        internal Guid Id { get; set; }

        public override User User { get; }

        public override Item Item { get; }

        public override DateTime IssuedDate { get; }

        public override DateTime DueDate { get; }

        public Rent(User user, Item item, int rentDays)
        {
            User = user;
            Item = item;
            IssuedDate = DateTime.Now.Date;
            DueDate = IssuedDate.AddDays(rentDays);
        }
    }
}
