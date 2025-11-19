using System.Drawing;

namespace Sadie.API.Interfaces.Game.Rooms.Bots;

public interface IRoomBotFactory
{
    IRoomBot Create(
        IRoomLogic room,
        int id, 
        Point point,
        double pointZ);
}