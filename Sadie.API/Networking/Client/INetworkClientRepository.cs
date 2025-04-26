using DotNetty.Transport.Channels;

namespace Sadie.API.Networking.Client;

public interface INetworkClientRepository : IAsyncDisposable
{
    void AddClient(IChannelId channelId, INetworkClient client);
    Task<bool> TryRemoveAsync(IChannelId channelId);
    Task DisconnectIdleClientsAsync();
    INetworkClient? TryGetClientByChannelId(IChannelId channelId);
}