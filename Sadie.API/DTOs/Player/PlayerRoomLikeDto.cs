namespace Sadie.API.DTOs.Player;

public record PlayerRoomLikeDto
{
    public int Id { get; set; }
    public long PlayerId { get; set; }
    public int RoomId { get; set; }
}