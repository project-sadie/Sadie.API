namespace Sadie.API.Interfaces.Networking.Client;

public interface INetworkClientConnectionHandler
{
    Task HandleClientAsync(INetworkClient client, CancellationToken ct);
}