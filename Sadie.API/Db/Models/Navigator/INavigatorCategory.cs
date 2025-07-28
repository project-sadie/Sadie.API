namespace Sadie.API.Db.Models.Navigator;

public interface INavigatorCategory
{
    int Id { get; init; }
    string Name { get; init; }
    string CodeName { get; init; }
    int OrderId { get; init; }
    int TabId { get; init; }
    INavigatorTab? Tab { get; init; }
}