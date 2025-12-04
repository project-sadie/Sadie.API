namespace Sadie.API.Interfaces.Networking.Packets;

public interface INetworkPacketDecoder
{
    INetworkPacket? Decode(Guid guid, ReadOnlySpan<byte> data);
}