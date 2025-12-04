namespace Sadie.API.Interfaces.Networking.Packets;

public interface INetworkPacket
{
    short PacketId { get; }
    byte[] Data { get; }
}