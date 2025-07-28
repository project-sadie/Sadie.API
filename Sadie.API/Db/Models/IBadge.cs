namespace Sadie.API.Db.Models;

public interface IBadge
{
    int Id { get; init; }
    string? Code { get; init; }
}