using DotNetty.Transport.Channels;

namespace Sadie.API.Interfaces.Networking.Client;

public interface INetworkClientRepository : IAsyncDisposable
{
    void AddClient(IChannelId channelId, INetworkClient client);
    Task<bool> TryRemoveAsync(IChannelId channelId);
    Task DisconnectIdleClientsAsync();
    INetworkClient? TryGetClientByChannelId(IChannelId channelId);
    ICollection<INetworkClient> Clients { get; }
}