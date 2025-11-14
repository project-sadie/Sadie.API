namespace Sadie.API.DTOs.Player;

public class PlayerIgnoreDto
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public long TargetPlayerId { get; init; }
}