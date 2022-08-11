// See https://aka.ms/new-console-template for more information
using RentalService.App_Console;
using RentalService.App_Console.Commands;
using RentalService.App_Console.Services;

var userService = new UserService();

var commands = new List<ICommand>()
{
    new GetUsersCommand(userService),
};

var commandhandler = new CommandHandler(commands);

var ui = new RentalServiceApp(commandhandler);

ui.Run();