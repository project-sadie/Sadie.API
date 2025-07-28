using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Game.Rooms.Users;

namespace Sadie.API.Game.Rooms.Furniture;

public interface IRoomFurnitureItemInteractor
{
    List<string> InteractionTypes { get; }
    Task OnTriggerAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser);
    Task OnPlaceAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser);
    Task OnPickUpAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser);
    Task OnMoveAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser);
}