using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.Interfaces.Game.Rooms.Users;

namespace Sadie.API.Interfaces.Game.Rooms.Furniture;

public interface IRoomFurnitureItemInteractor
{
    List<string> InteractionTypes { get; }
    Task OnTriggerAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser);
    Task OnPlaceAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser);
    Task OnPickUpAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser);
    Task OnMoveAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser);
}