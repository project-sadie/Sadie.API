namespace Sadie.API.DTOs.Player;

public class PlayerSavedSearchDto
{
    public int Id { get; set; }
    public string? Search { get; set; }
    public string? Filter { get; set; }
    public string Localization { get; set; } = "";
    public long PlayerId { get; set; }
}
