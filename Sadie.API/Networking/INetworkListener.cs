namespace Sadie.API.Networking;

public interface INetworkListener : IAsyncDisposable
{
    void Bootstrap();
    Task ListenAsync();
}