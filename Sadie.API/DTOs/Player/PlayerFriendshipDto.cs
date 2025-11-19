namespace Sadie.API.DTOs.Player;

public record PlayerFriendshipDto
{
    public int Id { get; set; }
    public long OriginPlayerId { get; set; }
    public long TargetPlayerId { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
}