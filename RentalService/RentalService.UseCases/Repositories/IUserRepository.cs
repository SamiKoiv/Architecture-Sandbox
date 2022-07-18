using RentalService.UseCases.Models;

namespace RentalService.UseCases.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}
