using Sadie.API.Db.Models.Furniture;

namespace Sadie.API.Db.Models.Catalog.Items;

public interface ICatalogItem
{
    int Id { get; init; }
    string? Name { get; init; }
    int CostCredits { get; init; }
    int CostPoints { get; init; }
    int CostPointsType { get; init; }
    ICollection<IFurnitureItem> FurnitureItems { get; init; }
    bool RequiresClubMembership { get; init; }
    string? MetaData { get; init; }
    int Amount { get; init; }
    int StackLimit { get; init; }
    int SellLimit { get; init; }
}