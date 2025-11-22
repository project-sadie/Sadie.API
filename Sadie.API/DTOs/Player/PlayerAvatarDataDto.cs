using Sadie.Core.Enums.Game.Players;
using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.DTOs.Player;

public record PlayerAvatarDataDto
{
    public string FigureCode { get; init; } = string.Empty;
    public string? Motto { get; init; }
    public PlayerAvatarGender Gender { get; init; }
    public ChatBubble ChatBubbleId { get; init; }
}