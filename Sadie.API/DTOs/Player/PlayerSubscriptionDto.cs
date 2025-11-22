namespace Sadie.API.DTOs.Player;

public record PlayerSubscriptionDto
{
    public PlayerDto? Player { get; init; }
    public int SubscriptionId { get; init; }
    public SubscriptionDto? Subscription { get; init; }
    public DateTimeOffset ExpiresAt { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}