using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.Interfaces.Game.Rooms.Users;

namespace Sadie.API.Interfaces.Game.Rooms.Services;

public interface IRoomWiredService
{
    IEnumerable<PlayerFurnitureItemPlacementDataDto> GetTriggers(
        string interactionType,
        IEnumerable<PlayerFurnitureItemPlacementDataDto> roomItems,
        string requiredMessage = "",
        List<int>? requiredSelectedIds = null);
    
    IEnumerable<PlayerFurnitureItemPlacementDataDto> GetEffectsForTrigger(
        PlayerFurnitureItemPlacementDataDto trigger,
        IEnumerable<PlayerFurnitureItemPlacementDataDto> roomItems);

    Task RunTriggerForRoomAsync(IRoomLogic room,
        PlayerFurnitureItemPlacementDataDto trigger,
        IRoomUser userWhoTriggered);

    int GetWiredCode(string interactionType);

    Task SaveSettingsAsync(
        PlayerFurnitureItemPlacementDataDto placementData,
        IDbContextFactory<SadieDbContext> dbContextFactory,
        PlayerFurnitureItemWiredData wiredData);
}