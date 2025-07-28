using System.Collections.Concurrent;
using System.Drawing;
using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Game.Rooms.Unit;

namespace Sadie.API.Game.Rooms.Mapping;

public interface IRoomTileMap : IRoomTileMapHelperService
{
    int SizeX { get; }
    int SizeY { get; }
    int Size { get; }
    short[,] Map { get; }
    ConcurrentDictionary<Point, List<IRoomUnitData>> UnitMap { get; }
    short[,] EffectMap { get; }
    short[,] ZMap { get; set; }
    short[,] TileExistenceMap { get; set; }
    void UpdateEffectMapForTile(int x, int y, ICollection<IPlayerFurnitureItemPlacementData> furnitureItems);
    void AddUnitToMap(Point point, IRoomUnitData unit);
    bool UsersAtPoint(Point point);
    bool TileExists(Point point);
}