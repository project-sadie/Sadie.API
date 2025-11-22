namespace Sadie.API.DTOs;

public record SubscriptionDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
}