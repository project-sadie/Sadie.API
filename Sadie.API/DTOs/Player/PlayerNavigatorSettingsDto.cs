using Sadie.Core.Shared.Attributes;

namespace Sadie.API.DTOs.Player;

public record PlayerNavigatorSettingsDto
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public PlayerDto? Player { get; init; }
    [PacketData] public int WindowX { get; init; }
    [PacketData] public int WindowY { get; init; }
    [PacketData] public int WindowWidth { get; init; }
    [PacketData] public int WindowHeight { get; init; }
    [PacketData] public bool OpenSearches { get; init; }
    [PacketData] public int ResultsMode { get; init; }
}