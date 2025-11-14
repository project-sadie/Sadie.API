namespace Sadie.API.Interfaces.Game.Rooms.Furniture;

public interface IRoomFurnitureItemInteractorRepository
{
    ICollection<IRoomFurnitureItemInteractor> GetInteractorsForType(string interactionType);
}