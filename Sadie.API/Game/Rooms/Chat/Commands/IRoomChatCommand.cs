using Sadie.API.Game.Rooms.Users;

namespace Sadie.API.Game.Rooms.Chat.Commands;

public interface IRoomChatCommand
{
    string Trigger { get; }
    string Description { get; }
    Task ExecuteAsync(IRoomUser user, IRoomChatCommandParameterReader reader);
    List<string> PermissionsRequired { get; set; }
    bool BypassPermissionCheckIfRoomOwner { get; }
    List<string> Parameters { get; }
}