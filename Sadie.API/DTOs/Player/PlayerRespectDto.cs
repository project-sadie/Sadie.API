namespace Sadie.API.DTOs.Player;

public record PlayerRespectDto
{
    public int Id { get; set; }
    public long OriginPlayerId { get; set; }
    public long TargetPlayerId { get; set; }
}