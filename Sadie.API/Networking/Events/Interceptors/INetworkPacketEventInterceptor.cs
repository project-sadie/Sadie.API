using Sadie.API.Networking.Client;
using Sadie.API.Networking.Events.Handlers;

namespace Sadie.API.Networking.Events.Interceptors;

public interface INetworkPacketEventInterceptor<in TPacket> where TPacket : INetworkPacketEventHandler
{
    Task InterceptAsync(INetworkClient client, TPacket packet);
}