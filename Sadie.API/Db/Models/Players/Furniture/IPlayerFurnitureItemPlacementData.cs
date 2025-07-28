using Sadie.API.Db.Models.Furniture;
using Sadie.API.Db.Models.Rooms;
using Sadie.Enums.Miscellaneous;

namespace Sadie.API.Db.Models.Players.Furniture;

public interface IPlayerFurnitureItemPlacementData
{
    int Id { get; init; }
    int PlayerFurnitureItemId { get; init; }
    IPlayerFurnitureItem PlayerFurnitureItem { get; init; }
    int RoomId { get; init; }
    IRoom? Room { get; init; }
    int PositionX { get; set; }
    int PositionY { get; set; }
    double PositionZ { get; set; }
    string? WallPosition { get; set; }
    HDirection Direction { get; set; }
    DateTimeOffset CreatedAt { get; init; }
    IPlayerFurnitureItemWiredData? WiredData { get; set; }
    ICollection<IPlayerFurnitureItemWiredData> SelectedBy { get; init; }
    IFurnitureItem FurnitureItem { get; }
}