using Sadie.API.DTOs.Player;
using Sadie.Core.Enums.Game.Rooms;
using Sadie.Core.Enums.Game.Rooms.Users;
using Sadie.Core.Enums.Miscellaneous;

namespace Sadie.API.DTOs.Rooms.Chat;

public class RoomChatMessageDto
{
    public int Id { get; init; }
    public int RoomId { get; init; }
    public long PlayerId { get; init; }
    public PlayerDto? Player { get; init; }
    public string? Message { get; init; }
    public ChatBubble ChatBubbleId { get; init; }
    public RoomUserEmotion EmotionId { get; init; }
    public RoomChatMessageType TypeId { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}