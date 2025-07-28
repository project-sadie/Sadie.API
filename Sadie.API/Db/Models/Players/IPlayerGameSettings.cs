namespace Sadie.API.Db.Models.Players;

public interface IPlayerGameSettings
{
    int Id { get; set; }
    long PlayerId { get; set; }
    IPlayer? Player { get; set; }
    int SystemVolume { get; init; }
    int FurnitureVolume { get; init; }
    int TraxVolume { get; init; }
    bool PreferOldChat { get; init; }
    bool BlockRoomInvites { get; init; }
    bool BlockCameraFollow { get; init; }
    int UiFlags { get; init; }
    bool ShowNotifications { get; init; }
}