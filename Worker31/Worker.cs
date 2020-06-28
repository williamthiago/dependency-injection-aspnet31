using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Shared;

namespace Worker31
{
    public class Worker : BackgroundService
    {
        private readonly IBooleanService _booleanService;

        public Worker(IBooleanService booleanService)
        {
            _booleanService = booleanService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine(_booleanService.GetBooleanValue());
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
