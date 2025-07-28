namespace Sadie.API.Db.Models;

public interface ISubscription
{
    int Id { get; init; }
    string? Name { get; init; }
}