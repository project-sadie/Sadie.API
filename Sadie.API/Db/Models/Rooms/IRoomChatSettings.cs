namespace Sadie.API.Db.Models.Rooms;

public interface IRoomChatSettings
{
    int Id { get; init; }
    int RoomId { get; init; }
    int ChatType { get; set; }
    int ChatWeight { get; set; }
    int ChatSpeed { get; set; }
    int ChatDistance { get; set; }
    int ChatProtection { get; set; }
}