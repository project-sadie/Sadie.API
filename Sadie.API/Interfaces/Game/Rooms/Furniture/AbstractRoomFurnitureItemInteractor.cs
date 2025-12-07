using Sadie.API.DTOs.Players.Furniture;
using Sadie.API.Interfaces.Game.Rooms.Users;

namespace Sadie.API.Interfaces.Game.Rooms.Furniture;

public abstract class AbstractRoomFurnitureItemInteractor : IRoomFurnitureItemInteractor
{
    public abstract List<string> InteractionTypes { get; }
    
    public virtual Task OnTriggerAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnPlaceAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnPickUpAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnMoveAsync(IRoomLogic room, PlayerFurnitureItemPlacementDataDto item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }
}