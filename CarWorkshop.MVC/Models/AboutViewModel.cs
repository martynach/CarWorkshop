namespace CarWorkshop.MVC.Models;

public class AboutViewModel
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public string[] Tags { get; set; } = Array.Empty<string>();

}
