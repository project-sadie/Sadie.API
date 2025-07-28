using System.Drawing;
using Sadie.API.Db.Models.Players.Furniture;
using Sadie.API.Game.Rooms.Users;
using Sadie.Enums.Game.Rooms.Mapping;
using Sadie.Enums.Game.Rooms.Users;
using Sadie.Enums.Miscellaneous;

namespace Sadie.API.Game.Rooms.Mapping;

public interface IRoomTileMapHelperService
{
    HDirection GetOppositeDirection(int direction);

    List<Point> GetPointsForPlacement(
        int x, 
        int y, 
        int width, 
        int length, 
        int direction);

    RoomTileState GetTileState(
        int x, 
        int y, 
        IEnumerable<IPlayerFurnitureItemPlacementData> furnitureItems);

    List<IPlayerFurnitureItemPlacementData> GetItemsForPosition(int x,
        int y,
        IEnumerable<IPlayerFurnitureItemPlacementData> items);

    short[,] GetWorldArrayFromTileMap(IRoomTileMap map,
        Point goalPoint,
        List<Point> overridePoints);

    void UpdateTileMapsForPoints(
        List<Point> points, 
        IRoomTileMap tileMap, 
        ICollection<IPlayerFurnitureItemPlacementData> furnitureItems);

    bool CanPlaceAt(
        IEnumerable<Point> points,  
        IRoomTileMap tileMap,
        bool checkForUsers = true);

    List<IRoomUser> GetUsersAtPoints(IEnumerable<Point> points, IEnumerable<IRoomUser> users);
    Point GetPointInFront(int x, int y, HDirection direction, int offset = 0);

    double GetItemPlacementHeight(
        IRoomTileMap roomTileMap,
        IEnumerable<Point> pointsForPlacement, 
        ICollection<IPlayerFurnitureItemPlacementData> roomFurnitureItems);

    int GetSquaresBetweenPoints(Point a, Point b);
    RoomUserEffect GetEffectFromInteractionType(string interactionType);
}