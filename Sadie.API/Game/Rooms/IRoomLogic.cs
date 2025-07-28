using Sadie.API.Game.Rooms.Bots;
using Sadie.API.Game.Rooms.Mapping;
using Sadie.API.Game.Rooms.Users;

namespace Sadie.API.Game.Rooms;

public interface IRoomLogic : IAsyncDisposable
{
    IRoomTileMap TileMap { get; }
    IRoomUserRepository UserRepository { get; }
    IRoomBotRepository BotRepository { get; }
}