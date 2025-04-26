using DotNetty.Transport.Channels;

namespace Sadie.API.Networking.Client;

public interface INetworkClientFactory
{
    INetworkClient CreateClient(IChannel channel);
}