namespace Sadie.API.DTOs.Player;

public record PlayerNavigatorSettingsDto
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public PlayerDto? Player { get; init; }
    public int WindowX { get; init; }
    public int WindowY { get; init; }
    public int WindowWidth { get; init; }
    public int WindowHeight { get; init; }
    public bool OpenSearches { get; init; }
    public int ResultsMode { get; init; }
}