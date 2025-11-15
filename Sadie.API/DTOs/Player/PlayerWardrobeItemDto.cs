namespace Sadie.API.DTOs.Player;

public class PlayerWardrobeItemDto
{
    public int Id { get; set; }
    public int SlotId { get; set; }
    public string? FigureCode { get; set; }
    public PlayerAvatarGender Gender { get; set; }
}
