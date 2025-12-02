using DotNetty.Transport.Channels.Groups;
using Sadie.API.DTOs.Rooms;
using Sadie.API.Interfaces.Game.Rooms.Bots;
using Sadie.API.Interfaces.Game.Rooms.Mapping;
using Sadie.API.Interfaces.Game.Rooms.Users;
using Sadie.API.Interfaces.Networking;

namespace Sadie.API.Interfaces.Game.Rooms;

public interface IRoomLogic : IAsyncDisposable
{
    RoomDto Room { get; }
    IRoomTileMap TileMap { get; }
    IRoomUserRepository UserRepository { get; }
    IRoomBotRepository BotRepository { get; }
    IChannelGroup ChannelGroup { get; set; }
    Task BroadcastDataAsync(AbstractPacketWriter writer, IReadOnlyCollection<long>? excludedIds = null);
    ValueTask DisposeAsync();
}