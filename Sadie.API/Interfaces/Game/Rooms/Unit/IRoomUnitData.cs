using System.Drawing;
using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.Interfaces.Game.Rooms.Unit;

public interface IRoomUnitData
{
    Point Point { get; }
    double PointZ { get; set; }
    bool IsWalking { get; set; }
    Point? NextPoint { get; set; }
    HDirection DirectionHead { get; set; }
    HDirection Direction { get; set; }
    bool CanWalk { get; set; }
    public Dictionary<string, string> StatusMap { get; }
    List<Point> OverridePoints { get; set; }
    void AddStatus(string key, string value);
    void RemoveStatuses(params string[] statuses);
    void WalkToPoint(Point point, Action? onReachedGoal = null);
    public double NextZ { get; set; }
    public int HandItemId { get; set; }
    public DateTime HandItemSet { get; set; }
    Task SetPositionAsync(Point point);
}