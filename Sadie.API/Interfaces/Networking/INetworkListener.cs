using DotNetty.Transport.Channels;

namespace Sadie.API.Interfaces.Networking;

public interface INetworkListener : IAsyncDisposable
{
    void Bootstrap();
    Task ListenAsync();
}