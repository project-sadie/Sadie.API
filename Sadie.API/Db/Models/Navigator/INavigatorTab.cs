namespace Sadie.API.Db.Models.Navigator;

public interface INavigatorTab
{
    int Id { get; init; }
    string? Name { get; init; }
    ICollection<INavigatorCategory> Categories { get; init; }
}