using Sadie.API.DTOs.Catalog.Pages;

namespace Sadie.API.Interfaces.Game.Catalog;

public interface ICatalogPageRepository
{
    IReadOnlyList<CatalogPageDto> Pages { get; }
    Task LoadAsync();
}