using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Game.Rooms.Users;

namespace Sadie.API.Game.Rooms.Furniture;

public abstract class AbstractRoomFurnitureItemInteractor : IRoomFurnitureItemInteractor
{
    public abstract List<string> InteractionTypes { get; }
    
    public virtual Task OnTriggerAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnPlaceAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnPickUpAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnMoveAsync(IRoomLogic room, IPlayerFurnitureItemPlacementData item, IRoomUser roomUser)
    {
        return Task.CompletedTask;
    }
}