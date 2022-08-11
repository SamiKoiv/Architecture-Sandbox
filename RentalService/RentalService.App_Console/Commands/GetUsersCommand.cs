using RentalService.App_Console.Services;

namespace RentalService.App_Console.Commands
{
    internal class GetUsersCommand : ICommand
    {
        private readonly UserService _userService;

        public string Name => "GetUsers";

        public GetUsersCommand(UserService userService)
        {
            _userService = userService;
        }

        public void Execute(string[] args)
        {
            System.Console.WriteLine("No users inserted");
            throw new NotImplementedException();
        }
    }
}
