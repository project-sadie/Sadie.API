using Sadie.API.Interfaces.Game.Players;
using Sadie.API.Interfaces.Game.Rooms.Users;

namespace Sadie.API.Interfaces.Networking.Client;

public interface INetworkClient : IAsyncDisposable, INetworkObject
{
    IPlayerLogic? Player { get; set; }
    IRoomUser? RoomUser { get; set; }
    bool EncryptionEnabled { get; }
    void EnableEncryption(byte[] sharedKey);
    DateTime LastPing { get; set; }
    DateTime LastPong { get; set; }
}