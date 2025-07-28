namespace Sadie.API.Db.Models.Rooms;

public interface IRoomCategory
{
    int Id { get; init; }
    string? Caption { get; init; }
    bool IsVisible { get; init; }
}