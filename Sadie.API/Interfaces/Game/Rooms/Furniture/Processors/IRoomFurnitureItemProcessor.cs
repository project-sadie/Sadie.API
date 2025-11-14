using Sadie.API.Interfaces.Networking;

namespace Sadie.API.Interfaces.Game.Rooms.Furniture.Processors;

public interface IRoomFurnitureItemProcessor
{
    Task<IEnumerable<AbstractPacketWriter>> GetUpdatesForRoomAsync(IRoomLogic roomLogic);
}