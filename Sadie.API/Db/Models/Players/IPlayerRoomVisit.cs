namespace Sadie.API.Db.Models.Players;

public interface IPlayerRoomVisit
{
    int Id { get; init; }
    long PlayerId { get; init; }
    int RoomId { get; init; }
    DateTime CreatedAt { get; init; }
}