namespace Sadie.API.Game.Locale;

public interface ILocaleService
{
    string this[string key] { get; set; }
}