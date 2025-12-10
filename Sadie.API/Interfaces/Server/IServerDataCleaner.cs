namespace Sadie.API.Interfaces.Server;

public interface IServerDataCleaner
{
    Task CleanAsync(CancellationToken token);
}