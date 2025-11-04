namespace Sadie.API.DTOs.Player.Furniture;

public class PlayerFurnitureItemWiredDataDto
{
    public string Message { get; init; } = string.Empty;
    public int Delay { get; init; }
    public List<int> SelectedItemIds { get; init; } = [];
}