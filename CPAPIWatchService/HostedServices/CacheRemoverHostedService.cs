using CPAPIWatchService.HostedServices.BLL;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CPAPIWatchService.HostedServices
{
    public class CacheRemoverHostedService : IHostedService, IDisposable
    {
        private readonly ILogger _logger;
        private Timer _timer;

        private static readonly log4net.ILog log = log4net.LogManager
           .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CacheRemoverHostedService(ILogger<CacheRemoverHostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CP CacheRemover Timed Background Service is starting.");
            log.Info("CP CacheRemover Timed Background Service is starting.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromHours(24));
            
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            _logger.LogInformation("Running ...CacheRemover");
            log.Info("Running ...CacheRemover");

            long BytesSize;
            CacheRemoverHosted.Run(out BytesSize);

            log.Info($"{FileSizeFormatter.FormatSize(BytesSize)} Cleaned UP");

            _logger.LogInformation("CacheRemover Done.");
            log.Info("CacheRemover Done.");


        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CP CacheRemover Timed Background Service is stopping.");
            log.Info("CP CacheRemover Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
