namespace Sadie.API.DTOs.Player;

public record PlayerBadgeDto
{
    public int BadgeId { get; init; }
    public string? BadgeCode { get; init; }
    public BadgeDto? Badge { get; init; }
    public int Slot { get; init; }
}