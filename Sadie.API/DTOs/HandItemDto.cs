using Sadie.API.DTOs.Furniture;

namespace Sadie.API.DTOs;

public record HandItemDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public ICollection<FurnitureItemDto> FurnitureItems { get; init; } = [];
}