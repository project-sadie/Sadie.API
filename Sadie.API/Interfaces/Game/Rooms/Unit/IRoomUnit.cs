namespace Sadie.API.Interfaces.Game.Rooms.Unit;

public interface IRoomUnit : IRoomUnitData
{
    Task RunPeriodicCheckAsync();
}