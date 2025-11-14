namespace Sadie.API.Interfaces.Networking.Events.Dtos;

public interface IGroupBadgeData
{
    int GroupId { get; set; }
    string Badge { get; set; }
}