using Sadie.API.Db.Models.Catalog.Items;

namespace Sadie.API.Db.Models.Catalog.Pages;

public interface ICatalogPage
{
    int Id { get; init; }
    string? Name { get; init; }
    string? Caption { get; init; }
    string? Layout { get; init; }
    int? RoleId { get; init; }
    int? CatalogPageId { get; init; }
    int OrderId { get; init; }
    int IconId { get; init; }
    bool Enabled { get; init; }
    bool Visible { get; init; }
    List<string> ImagesJson { get; init; }
    List<string> TextsJson { get; init; }
    ICollection<ICatalogPage> Pages { get; init; }
    ICollection<ICatalogItem> Items { get; init; }
}