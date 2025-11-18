namespace Sadie.API.DTOs.Player;

public record PlayerNavigatorSettingsDto
{
    public int WindowX { get; init; }
    public int WindowY { get; init; }
    public int WindowWidth { get; init; }
    public int WindowHeight { get; init; }
    public bool OpenSearches { get; init; }
    public int ResultsMode { get; init; }
}