using RentalService.NonPersistingDataAccess.Models;

namespace RentalService.NonPersistingDataAccess
{
    internal static class DB
    {
        internal static readonly List<Item> Items = new List<Item>();
        internal static readonly List<Rent> Rents = new List<Rent>();
        internal static readonly List<User> Users = new List<User>();
    }
}
