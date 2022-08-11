using RentalService.Main;

var di = new DI();
di.Configure(args);
var services = di.GetServices();