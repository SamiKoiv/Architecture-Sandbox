using RentalService.Interfaces.Controllers;

namespace RentalService.ConsoleUI.Commands
{
    public class GetUsersCommand : ICommand
    {
        private readonly UserController _userController;

        public string Name => "GetUsers";

        public GetUsersCommand(UserController userController)
        {
            _userController = userController;
        }

        public void Execute(string[] args)
        {
            System.Console.WriteLine("No users inserted");
            throw new NotImplementedException();
        }
    }
}
