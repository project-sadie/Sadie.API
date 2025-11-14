namespace Sadie.API.DTOs.Player;

public class PlayerRoomVisitDto
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public int RoomId { get; init; }
    public DateTime CreatedAt { get; init; }
}