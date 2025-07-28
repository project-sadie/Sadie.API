using Sadie.API.Db.Models.Catalog.Pages;
using Sadie.Enums.Unsorted;

namespace Sadie.API.Db.Models.Catalog.FrontPage;

public interface ICatalogFrontPageItem
{
    int Id { get; init; }
    string? Title { get; init; }
    string? Image { get; init; }
    CatalogFrontPageItemType TypeId { get; init; }
    string? ProductName { get; init; }
    int CatalogPageId { get; set; }
    ICatalogPage CatalogPage { get; init; }
}