using Sadie.API.DTOs.Player;
using Sadie.API.Interfaces.Game.Rooms.Unit;

namespace Sadie.API.Interfaces.Game.Rooms.Bots;

public interface IRoomBot : IRoomUnit
{ 
    PlayerBotDto Bot { get; }
}