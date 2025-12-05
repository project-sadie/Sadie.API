using Sadie.Core.Enums.Game.Players;
using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.DTOs.Players;

public record PlayerAvatarDataDto
{
    public string? FigureCode { get; set; }
    public string? Motto { get; set; }
    public PlayerAvatarGender Gender { get; set; }
    public ChatBubble ChatBubbleId { get; set; }
}