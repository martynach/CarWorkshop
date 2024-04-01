namespace CarWorkshop.Domain.Entities;

public class CarWorkshop
{
    public int Id { get; set; }

    private string _name;
    public required string Name
    {
        get => _name;
        set
        {
            _name = value;
            EncodeName();
        }
    }

    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required CarWorkshopContactDetails ContactDetails { get; init; }
    
    // encodowanie:
    //     chcemy aby ASO%20Mazda bylo wyswietlone w przegladarce jako aso-mazda
    public string EncodedName { get; private set; }

    private void EncodeName() => EncodedName = Name?.ToLower().Replace(" ", "-") ?? "";

    public string? About { get; set; }

}