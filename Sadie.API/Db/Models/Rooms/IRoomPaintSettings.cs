namespace Sadie.API.Db.Models.Rooms;

public interface IRoomPaintSettings
{
    int Id { get; init; }
    IRoom? Room { get; init; }
    int RoomId { get; init; }
    string FloorPaint { get; init; }
    string WallPaint { get; init; }
    string LandscapePaint { get; init; }
}