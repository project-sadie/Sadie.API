using Sadie.Db.Models.Catalog.Pages;

namespace Sadie.API.Game.Catalog;

public interface ICatalogPageRepository
{
    IReadOnlyList<CatalogPage> Pages { get; }
    Task LoadAsync();
}