namespace Sadie.API.Db.Models.Players.Furniture;

public interface IPlayerFurnitureItemLink
{
    int Id { get; init; }
    int ParentId { get; init; }
    IPlayerFurnitureItem? Parent { get; init; }
    int ChildId { get; init; }
    IPlayerFurnitureItem? Child { get; init; }
}