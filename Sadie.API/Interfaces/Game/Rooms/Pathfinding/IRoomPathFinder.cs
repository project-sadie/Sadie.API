using System.Drawing;
using Sadie.API.Interfaces.Game.Rooms.Pathfinding.ToGo;

namespace Sadie.API.Interfaces.Game.Rooms.Pathfinding;

public interface IRoomPathFinder
{
    IEnumerable<Point> FindPath(Point start, Point end, IWorldGrid world);
}