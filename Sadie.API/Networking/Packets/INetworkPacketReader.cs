namespace Sadie.API.Networking.Packets;

public interface INetworkPacketReader
{
    string ReadString();
    int ReadInt();
    bool ReadBool();
    long ReadLong();
}