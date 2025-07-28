using Sadie.API.Db.Models.Players.Furniture;
using Sadie.Enums.Miscellaneous;

namespace Sadie.API.Game.Rooms.Furniture;

public interface IRoomFurnitureItemHelperService
{
    Task CycleInteractionStateForItemAsync(
        IRoomLogic room, 
        IPlayerFurnitureItemPlacementData roomFurnitureItem);

    Task UpdateMetaDataForItemAsync(
        IRoomLogic room, 
        IPlayerFurnitureItemPlacementData roomFurnitureItem, 
        string metaData);

    Task BroadcastItemUpdateToRoomAsync(
        IRoomLogic room, 
        IPlayerFurnitureItemPlacementData roomFurnitureItem);

    ObjectDataKey GetObjectDataKeyForItem(IPlayerFurnitureItemPlacementData furnitureItem);
    Dictionary<string, string> GetObjectDataForItem(IPlayerFurnitureItemPlacementData furnitureItem);
}