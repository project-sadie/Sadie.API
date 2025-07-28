namespace Sadie.API.Db.Models.Rooms;

public interface IRoomDimmerSettings
{
    int Id { get; init; }
    int RoomId { get; init; }
    bool Enabled { get; set; }
    int PresetId { get; init; }
}