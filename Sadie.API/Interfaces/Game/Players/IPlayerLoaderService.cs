using Sadie.API.DTOs.Players;

namespace Sadie.API.Interfaces.Game.Players;

public interface IPlayerLoaderService
{
    Task<PlayerSsoTokenDto?> GetTokenAsync(string token, int delayMs);
}