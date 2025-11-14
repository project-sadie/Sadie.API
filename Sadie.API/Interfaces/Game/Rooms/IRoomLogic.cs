using Sadie.API.Interfaces.Game.Rooms.Bots;
using Sadie.API.Interfaces.Game.Rooms.Mapping;
using Sadie.API.Interfaces.Game.Rooms.Users;

namespace Sadie.API.Interfaces.Game.Rooms;

public interface IRoomLogic : IAsyncDisposable
{
    IRoomTileMap TileMap { get; }
    IRoomUserRepository UserRepository { get; }
    IRoomBotRepository BotRepository { get; }
    int IdleTicks { get; set; }
}