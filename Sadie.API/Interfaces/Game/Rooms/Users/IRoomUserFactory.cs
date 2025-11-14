using System.Drawing;
using Sadie.API.Interfaces.Game.Players;

namespace Sadie.API.Interfaces.Game.Rooms.Users;

public interface IRoomUserFactory
{
    IRoomUser Create(
        IRoomLogic room,
        INetworkObject networkObject, 
        Point point, 
        double pointZ,
        HDirection directionHead,
        HDirection direction, 
        IPlayerLogic player,
        RoomControllerLevel controllerLevel);
}