namespace Sadie.API.Db.Models.Rooms.Rights;

public interface IRoomPlayerRight
{
    int Id { get; init; }
    int RoomId { get; init; }
    long PlayerId { get; init; }
    DateTime CreatedAt { get; init; }
}