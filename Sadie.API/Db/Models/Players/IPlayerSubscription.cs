namespace Sadie.API.Db.Models.Players;

public interface IPlayerSubscription
{
    int Id { get; init; }
    long PlayerId { get; init; }
    IPlayer? Player { get; init; }
    int SubscriptionId { get; init; }
    ISubscription? Subscription { get; init; }
    DateTimeOffset ExpiresAt { get; init; }
    DateTimeOffset CreatedAt { get; init; }
}