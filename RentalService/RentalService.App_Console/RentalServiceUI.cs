using RentalService.App_Console.Commands;

namespace RentalService.App_Console
{
    internal class RentalServiceApp
    {
        private CommandHandler _handler;

        public RentalServiceApp(CommandHandler handler)
        {
            _handler = handler;
        }


        public void Run()
        {
            Console.Title = nameof(RentalServiceApp);

            Console.WriteLine("Welcome to RentalService! \n");

            while (true)
            {
                try
                {
                    Console.Write("Type command: ");
                    var input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                        continue;

                    if (input.Equals("exit"))
                        break;

                    _handler.HandleCommand(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            Console.WriteLine("\nThank you and please come again!");
        }
    }
}
