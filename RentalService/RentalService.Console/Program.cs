using Microsoft.Extensions.DependencyInjection;
using RentalService.ConsoleUI;
using RentalService.Main;

var di = new DI();
di.Configure(args);
var services = di.GetServices();

var ui = services?.GetRequiredService<RentalServiceUI>();
ui?.Run();