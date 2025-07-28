using Sadie.API.Db.Models.Furniture;

namespace Sadie.API.Db.Models;

public interface IHandItem
{
    int Id { get; init; }
    string Name { get; init; }
    ICollection<IFurnitureItem> FurnitureItems { get; init; }
}