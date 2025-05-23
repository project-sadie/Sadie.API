using Sadie.Db.Models.Players;

namespace Sadie.API.Game.Players;

public interface IPlayerLoaderService
{
    Task<PlayerSsoToken?> GetTokenAsync(string token, int delayMs);
}