namespace Sadie.API.Db.Models.Players.Furniture;

public interface IPlayerFurnitureItemWiredData
{
    int Id { get; init; }
    int PlayerFurnitureItemPlacementDataId { get; init; }
    IPlayerFurnitureItemPlacementData PlacementData { get; init; }
    ICollection<IPlayerFurnitureItemPlacementData> SelectedItems { get; init; }
    string Message { get; init; }
    int Delay { get; init; }
}