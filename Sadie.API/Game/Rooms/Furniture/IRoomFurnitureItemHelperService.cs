using Microsoft.EntityFrameworkCore;
using Sadie.Db;
using Sadie.Db.Models.Players.Furniture;
using Sadie.Enums.Miscellaneous;

namespace Sadie.API.Game.Rooms.Furniture;

public interface IRoomFurnitureItemHelperService
{
    Task CycleInteractionStateForItemAsync(
        IRoomLogic room, 
        PlayerFurnitureItemPlacementData roomFurnitureItem,
        IDbContextFactory<SadieDbContext> dbContextFactory);

    Task UpdateMetaDataForItemAsync(
        IRoomLogic room, 
        PlayerFurnitureItemPlacementData roomFurnitureItem, 
        string metaData);

    Task BroadcastItemUpdateToRoomAsync(
        IRoomLogic room, 
        PlayerFurnitureItemPlacementData roomFurnitureItem);

    ObjectDataKey GetObjectDataKeyForItem(PlayerFurnitureItemPlacementData furnitureItem);
    Dictionary<string, string> GetObjectDataForItem(PlayerFurnitureItemPlacementData furnitureItem);
}