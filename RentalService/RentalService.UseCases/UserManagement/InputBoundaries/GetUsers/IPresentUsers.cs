using RentalService.UseCases.UserManagement.InputBoundaries.GetUsers;

namespace RentalService.UseCases.UserManagement.Presenters
{
    internal interface IPresentUsers
    {
        void ListUsers(ICollection<UserDto> users);
    }
}
