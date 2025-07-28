using Sadie.API.Game.Rooms.Users;
using Sadie.Db.Models.Players.Furniture;

namespace Sadie.API.Game.Rooms.Furniture;

public interface IRoomFurnitureItemInteractor
{
    List<string> InteractionTypes { get; }
    Task OnTriggerAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser);
    Task OnPlaceAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser);
    Task OnPickUpAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser);
    Task OnMoveAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser);
}