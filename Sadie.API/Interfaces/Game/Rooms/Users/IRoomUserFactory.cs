using System.Drawing;
using Sadie.API.Interfaces.Game.Players;
using Sadie.Core.Enums.Game.Rooms;
using Sadie.Core.Enums.Miscellaneous;

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