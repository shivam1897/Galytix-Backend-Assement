using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GWP.Worker
{
    public class Worker : BackgroundService
    {
        private bool _servicesNotInitialized;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (!_servicesNotInitialized)
            {
                InitServices();
            }
            await WhenCancelled(stoppingToken);
        }

        private void InitServices()
        {
            _servicesNotInitialized = true;
        }

        private Task WhenCancelled(CancellationToken stoppingToken)
        {
            var taskCancellationToken = new TaskCompletionSource<bool>();
            stoppingToken.Register(s => ((TaskCompletionSource<bool>)s).SetResult(true), taskCancellationToken);
            return taskCancellationToken.Task;
        }
    }
}
