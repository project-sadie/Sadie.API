using Sadie.API.Game.Rooms.Unit;
using Sadie.Db.Models.Players;

namespace Sadie.API.Game.Rooms.Bots;

public interface IRoomBot : IRoomUnit
{ 
    PlayerBot Bot { get; }
}