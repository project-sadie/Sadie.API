using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Game.Rooms.Users;

namespace Sadie.API.Game.Rooms.Services;

public interface IRoomWiredService
{
    IEnumerable<IPlayerFurnitureItemPlacementData> GetTriggers(
        string interactionType,
        IEnumerable<IPlayerFurnitureItemPlacementData> roomItems,
        string requiredMessage = "",
        List<int>? requiredSelectedIds = null);
    
    IEnumerable<IPlayerFurnitureItemPlacementData> GetEffectsForTrigger(
        IPlayerFurnitureItemPlacementData trigger,
        IEnumerable<IPlayerFurnitureItemPlacementData> roomItems);

    Task RunTriggerForRoomAsync(IRoomLogic room,
        IPlayerFurnitureItemPlacementData trigger,
        IRoomUser userWhoTriggered);

    int GetWiredCode(string interactionType);

    Task SaveSettingsAsync(
        IPlayerFurnitureItemPlacementData placementData,
        IPlayerFurnitureItemWiredData wiredData);
}