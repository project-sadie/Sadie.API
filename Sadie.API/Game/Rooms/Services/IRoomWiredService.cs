using Microsoft.EntityFrameworkCore;
using Sadie.API.Game.Rooms.Users;
using Sadie.Db;
using Sadie.Db.Models.Players.Furniture;

namespace Sadie.API.Game.Rooms.Services;

public interface IRoomWiredService
{
    IEnumerable<PlayerFurnitureItemPlacementData> GetTriggers(
        string interactionType,
        IEnumerable<PlayerFurnitureItemPlacementData> roomItems,
        string requiredMessage = "",
        List<int>? requiredSelectedIds = null);
    
    IEnumerable<PlayerFurnitureItemPlacementData> GetEffectsForTrigger(
        PlayerFurnitureItemPlacementData trigger,
        IEnumerable<PlayerFurnitureItemPlacementData> roomItems);

    Task RunTriggerForRoomAsync(IRoomLogic room,
        PlayerFurnitureItemPlacementData trigger,
        IRoomUser userWhoTriggered);

    int GetWiredCode(string interactionType);

    Task SaveSettingsAsync(
        PlayerFurnitureItemPlacementData placementData,
        IDbContextFactory<SadieContext> dbContextFactory,
        PlayerFurnitureItemWiredData wiredData);
}