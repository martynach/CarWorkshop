
namespace CarWorkshop.Application.Dtos;

public class CarWorkshopDto
{

    public required string Name { get; set; }
    
    public string? Description { get; set; }
    public string? About { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
}