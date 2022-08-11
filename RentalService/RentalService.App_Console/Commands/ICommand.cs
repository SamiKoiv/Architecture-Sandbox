namespace RentalService.App_Console.Commands
{
    internal interface ICommand
    {
        string Name { get; }
        void Execute(string[] args);
    }
}
