using Sadie.API.Db.Models.Players;

namespace Sadie.API.Db.Models.Server;

public interface IServerPeriodicCurrencyRewardLog
{
    int Id { get; init; }
    long PlayerId { get; init; }
    IPlayer Player { get; init; }
    string? Type { get; init; }
    int Amount { get; init; }
    DateTimeOffset CreatedAt { get; init; }
}