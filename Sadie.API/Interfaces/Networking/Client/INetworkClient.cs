using System.Threading.Channels;
using DotNetty.Transport.Channels;
using Sadie.API.Interfaces.Game.Players;
using Sadie.API.Interfaces.Game.Rooms.Users;
using Sadie.API.Interfaces.Networking.Packets;

namespace Sadie.API.Interfaces.Networking.Client;

public interface INetworkClient : IAsyncDisposable, INetworkObject
{
    IChannel Channel { get; set; }
    IPlayerLogic? Player { get; set; }
    IRoomUser? RoomUser { get; set; }
    bool EncryptionEnabled { get; }
    void EnableEncryption(byte[] sharedKey);
    DateTime LastPing { get; set; }
    DateTime LastPong { get; set; }
}