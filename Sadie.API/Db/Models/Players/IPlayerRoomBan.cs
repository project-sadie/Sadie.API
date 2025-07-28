namespace Sadie.API.Db.Models.Players;

public interface IPlayerRoomBan
{
    int Id { get; init; }
    long PlayerId { get; init; }
    IPlayer? Player { get; init; }
    int RoomId { get; init; }
    DateTimeOffset ExpiresAt { get; init; }
}