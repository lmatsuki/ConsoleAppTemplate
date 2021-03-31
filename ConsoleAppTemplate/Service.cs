using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTemplate
{
    public class Service : IHostedService
    {
        private ILogger<Service> _logger;
        private IConfiguration _configuration;
        private IHostApplicationLifetime _hostApplicationLifetime;

        public Service(ILogger<Service> logger, IConfiguration configuration,
            IHostApplicationLifetime hostApplicationLifetime)
        {
            _logger = logger;
            _configuration = configuration;
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await Process(cancellationToken);

            // Manually stop the application
            _hostApplicationLifetime.StopApplication();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task Process(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Work is started");

            // Do work

            _logger.LogInformation("Work is completed");
        }
    }
}
