using RentalService.ConsoleUI;

namespace RentalService.ConsoleUI.Commands
{
    public class CommandHandler
    {
        private readonly Dictionary<string, ICommand> _commands;

        public CommandHandler(GetUsersCommand getUsersCommand)
        {
            _commands = new List<ICommand>()
            {
                getUsersCommand
            }
            .ToDictionary(c => c.Name.ToLower());
        }

        public void HandleCommand(string commandString)
        {
            var strings = commandString.Split(' ');
            try
            {
                var cmd = _commands[strings[0].ToLower()];
                var args = strings.Skip(1).ToArray();
                cmd.Execute(args);
            }
            catch (KeyNotFoundException)
            {
                System.Console.WriteLine("Command not found");
            }
        }
    }
}
