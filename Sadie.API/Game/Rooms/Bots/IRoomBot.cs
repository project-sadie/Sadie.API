using Sadie.API.Db.Models.Players;
using Sadie.API.Game.Rooms.Unit;

namespace Sadie.API.Game.Rooms.Bots;

public interface IRoomBot : IRoomUnit
{ 
    IPlayerBot Bot { get; }
}