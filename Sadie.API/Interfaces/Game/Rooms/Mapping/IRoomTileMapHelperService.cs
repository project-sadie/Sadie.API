using System.Drawing;
using Sadie.API.DTOs.Player.Furniture;
using Sadie.API.Interfaces.Game.Rooms.Users;
using Sadie.Core.Enums.Game.Rooms.Mapping;
using Sadie.Core.Enums.Game.Rooms.Users;
using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.Interfaces.Game.Rooms.Mapping;

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
        IEnumerable<PlayerFurnitureItemPlacementDataDto> furnitureItems);

    List<PlayerFurnitureItemPlacementDataDto> GetItemsForPosition(int x,
        int y,
        IEnumerable<PlayerFurnitureItemPlacementDataDto> items);

    short[,] GetWorldArrayFromTileMap(IRoomTileMap map,
        Point goalPoint,
        List<Point> overridePoints);

    void UpdateTileMapsForPoints(
        List<Point> points, 
        IRoomTileMap tileMap, 
        ICollection<PlayerFurnitureItemPlacementDataDto> furnitureItems);

    bool CanPlaceAt(
        IEnumerable<Point> points,  
        IRoomTileMap tileMap,
        bool checkForUsers = true);

    List<IRoomUser> GetUsersAtPoints(IEnumerable<Point> points, IEnumerable<IRoomUser> users);
    Point GetPointInFront(int x, int y, HDirection direction, int offset = 0);

    double GetItemPlacementHeight(
        IRoomTileMap roomTileMap,
        IEnumerable<Point> pointsForPlacement, 
        ICollection<PlayerFurnitureItemPlacementDataDto> roomFurnitureItems);

    int GetSquaresBetweenPoints(Point a, Point b);
    RoomUserEffect GetEffectFromInteractionType(string interactionType);
}