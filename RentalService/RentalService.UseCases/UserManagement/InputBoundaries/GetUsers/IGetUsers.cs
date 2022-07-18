namespace RentalService.UseCases.UserManagement.InputBoundaries.GetUsers
{
    public interface IGetUsers
    {
        IEnumerable<UserDto> GetUsers();
    }
}
