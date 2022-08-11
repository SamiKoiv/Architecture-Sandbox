using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RentalService.Main.Logging;
using RentalService.NonPersistingDataAccess.Repositories;
using RentalService.UseCases.Repositories;

namespace RentalService.Main
{
    internal class DI
    {
        private IHost? _host;
        private IServiceProvider? _services;

        public void Configure(string[] args)
        {
            _host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                services
                .AddScoped<ILogger, ConsoleLogger>()
                .AddTransient<IUserRepository, UserRepository>()
                )
                .Build();

            _services = _host.Services.CreateScope().ServiceProvider;

            _host.StartAsync();
        }

        public IServiceProvider? GetServices() => _services;
    }
}
