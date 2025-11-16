using Sadie.API.DTOs.Rooms;

namespace Sadie.API.Interfaces.Game.Rooms;

public interface IRoomRepository
{
    IRoomLogic? TryGetRoomById(long id);
    void AddRoom(IRoomLogic roomLogic);
    List<RoomDto> GetPopularRooms(int amount);
    int Count { get; }
    IEnumerable<IRoomLogic> GetAllRooms();
    bool TryRemove(long id, out IRoomLogic? roomLogic);
    ValueTask DisposeAsync();
}