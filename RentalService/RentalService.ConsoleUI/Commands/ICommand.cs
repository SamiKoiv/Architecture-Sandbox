namespace RentalService.ConsoleUI.Commands
{
    internal interface ICommand
    {
        string Name { get; }
        void Execute(string[] args);
    }
}
