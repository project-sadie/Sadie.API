using Sadie.API.Game.Rooms.Users;
using Sadie.Db.Models.Players.Furniture;

namespace Sadie.API.Game.Rooms.Furniture;

public abstract class AbstractRoomFurnitureItemInteractor : IRoomFurnitureItemInteractor
{
    public abstract List<string> InteractionTypes { get; }
    
    public virtual Task OnTriggerAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnPlaceAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnPickUpAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnMoveAsync(IRoomLogic room, PlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }
}