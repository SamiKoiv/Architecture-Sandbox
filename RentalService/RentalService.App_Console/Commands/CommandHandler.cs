using RentalService.App_Console;

namespace RentalService.App_Console.Commands
{
    internal class CommandHandler
    {
        private readonly Dictionary<string, ICommand> _commands;

        internal CommandHandler(GetUsersCommand getUsersCommand)
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
