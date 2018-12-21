using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace YourGameOfTheYear.ViewComponents
{
    public class UpdateTrending : IHostedService, IDisposable
    {
        private Task _executingTask;
        private readonly CancellationTokenSource _stoppingCts = new CancellationTokenSource();
        public UpdateTrending()
        {

        }
        public virtual Task StartAsync(CancellationToken canllationToken)
        {
            return null;
        }
        public virtual Task StopAsync(CancellationToken cancellationToken)
        {
            return null;
        }
        public virtual void Dispose()
        {

        }
    }

}
