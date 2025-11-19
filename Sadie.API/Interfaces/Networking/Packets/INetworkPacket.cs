namespace Sadie.API.Interfaces.Networking.Packets;

public interface INetworkPacket : INetworkPacketReader
{
    short PacketId { get; }
}