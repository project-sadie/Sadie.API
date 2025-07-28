namespace Sadie.API.Db.Models.Players;

public interface IPlayerSavedSearch
{
    int Id { get; init; }
    string? Search { get; init; }
    string? Filter { get; init; }
    string Localization { get; }
    long PlayerId { get; init; }
}