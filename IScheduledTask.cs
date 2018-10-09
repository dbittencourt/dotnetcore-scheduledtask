using System.Threading;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public interface IScheduledTask
    {
        string Schedule { get; }
        Task ExecuteAsync(CancellationToken cancellationToken);
    }
}