using RentalService.UseCases.Models;
using RentalService.UseCases.Repositories;

namespace RentalService.NonPersistingDataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            return DB.Users;
        }

        public void AddTestData()
        {
            DB.Users.Add(new NonPersistingDataAccess.Models.User("John Doe"));
            DB.Users.Add(new NonPersistingDataAccess.Models.User("Travis Johnson"));
            DB.Users.Add(new NonPersistingDataAccess.Models.User("Marilyn Presley"));
        }
    }
}
