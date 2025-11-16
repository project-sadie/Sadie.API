namespace Sadie.API.DTOs.Player;

public record PlayerSubscriptionDto
{
    public int SubscriptionId { get; init; }
    public string? SubscriptionType { get; init; }
    public DateTimeOffset ExpiresAt { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}