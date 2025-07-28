namespace Sadie.API.Db.Models.Players;

public interface IPlayerRoomLike
{
    int Id { get; init; }
    long PlayerId { get; init; }
    int RoomId { get; init; }
}