namespace Sadie.API.Db.Models.Players;

public interface IPlayerNavigatorSettings
{
    int Id { get; init; }
    long PlayerId { get; init; }
    IPlayer? Player { get; init; }
    int WindowX { get; set; }
    int WindowY { get; set; }
    int WindowWidth { get; set; }
    int WindowHeight { get; set; }
    bool OpenSearches { get; set; }
    int ResultsMode { get; set; }
}