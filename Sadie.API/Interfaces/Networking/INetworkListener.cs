using DotNetty.Transport.Channels;

namespace Sadie.API.Interfaces.Networking;

public interface INetworkListener : IAsyncDisposable
{
    IEventLoopGroup? WorkerGroup { get; }
    void Bootstrap();
    Task ListenAsync();
}