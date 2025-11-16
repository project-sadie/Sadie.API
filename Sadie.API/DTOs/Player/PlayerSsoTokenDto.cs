namespace Sadie.API.DTOs.Player;

public record PlayerSsoTokenDto
{
    public string? Token { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset ExpiresAt { get; init; }
    public DateTimeOffset? UsedAt { get; init; }
}