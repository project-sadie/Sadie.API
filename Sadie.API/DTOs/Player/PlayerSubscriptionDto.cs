namespace Sadie.API.DTOs.Player;

public class PlayerSubscriptionDto
{
    public int SubscriptionId { get; init; }
    public string? SubscriptionType { get; init; }
    public DateTimeOffset ExpiresAt { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}