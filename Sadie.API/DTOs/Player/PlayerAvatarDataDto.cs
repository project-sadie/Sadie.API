namespace Sadie.API.DTOs.Player;

public class PlayerAvatarDataDto
{
    public string FigureCode { get; init; } = string.Empty;
    public string? Motto { get; init; }
    public string Gender { get; init; } = string.Empty;
    public int ChatBubbleId { get; init; }
}