namespace Sadie.API.Networking.Packets;

public interface INetworkPacket : INetworkPacketReader
{
    short PacketId { get; }
}