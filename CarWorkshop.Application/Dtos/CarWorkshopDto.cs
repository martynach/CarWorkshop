using System.ComponentModel.DataAnnotations;

namespace CarWorkshop.Application.Dtos;

public class CarWorkshopDto
{
    [Required(ErrorMessage = "Nazwa warsztatu jest wymagana")]
    [StringLength(50, MinimumLength = 5)]
    public required string Name { get; set; }
    
    [StringLength(50, MinimumLength = 3)]
    public string? Description { get; set; }
    public string? About { get; set; }
    
    [StringLength(20, MinimumLength = 9)]
    public string PhoneNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
}