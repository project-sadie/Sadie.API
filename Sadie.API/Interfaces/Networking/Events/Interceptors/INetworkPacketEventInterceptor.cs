using Sadie.API.Interfaces.Networking.Client;
using Sadie.API.Interfaces.Networking.Events.Handlers;

namespace Sadie.API.Interfaces.Networking.Events.Interceptors;

public interface INetworkPacketEventInterceptor<in TPacket> where TPacket : INetworkPacketHandler
{
    Task InterceptAsync(INetworkClient client, TPacket packet);
}