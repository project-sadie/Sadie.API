namespace Sadie.API.Interfaces.Server.Tasks;

public interface IServerTaskWorker : IDisposable
{
    Task WorkAsync(CancellationToken token);
}