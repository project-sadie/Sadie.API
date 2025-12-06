using System.Drawing;
using Sadie.API.Interfaces.Game.Rooms.Mapping;
using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.Interfaces.Game.Rooms.Pathfinding;

public interface IRoomPathFinderHelperService
{
    HDirection GetDirectionForNextStep(Point current, Point next);

    List<Point> BuildPathForWalk(IRoomLogic room,
        Point start,
        Point end,
        bool useDiagonal,
        List<Point> overridePoints);
}