using DotNetty.Transport.Channels;

namespace Sadie.API.Interfaces.Networking.Client;

public interface INetworkClientFactory
{
    INetworkClient CreateClient(IChannel channel);
}