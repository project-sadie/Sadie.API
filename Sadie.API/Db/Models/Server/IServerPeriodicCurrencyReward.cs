namespace Sadie.API.Db.Models.Server;

public interface IServerPeriodicCurrencyReward
{
    int Id { get; init; }
    string? Type { get; init; }
    int Amount { get; init; }
    int IntervalSeconds { get; init; }
    bool SkipIdle { get; init; }
    bool SkipHotelView { get; init; }
}