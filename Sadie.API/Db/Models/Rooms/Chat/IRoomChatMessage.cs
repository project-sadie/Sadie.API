using Sadie.API.Db.Models.Players;
using Sadie.Enums.Game.Rooms;
using Sadie.Enums.Game.Rooms.Users;
using Sadie.Enums.Miscellaneous;

namespace Sadie.API.Db.Models.Rooms.Chat;

public interface IRoomChatMessage
{
    int Id { get; init; }
    int RoomId { get; init; }
    long PlayerId { get; init; }
    IPlayer? Player { get; init; }
    string? Message { get; init; }
    ChatBubble ChatBubbleId { get; init; }
    RoomUserEmotion EmotionId { get; init; }
    RoomChatMessageType TypeId { get; init; }
    DateTimeOffset CreatedAt { get; init; }
}