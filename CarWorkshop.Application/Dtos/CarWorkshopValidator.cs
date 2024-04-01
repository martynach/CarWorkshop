using CarWorkshop.Domain.Interfaces;
using FluentValidation;

namespace CarWorkshop.Application.Dtos;

public class CarWorkshopValidator: AbstractValidator<CarWorkshopDto>
{
    private readonly ICarWorkshopRepository _carWorkshopRepository;

    public CarWorkshopValidator(ICarWorkshopRepository carWorkshopRepository)
    {
        _carWorkshopRepository = carWorkshopRepository;
        RuleFor(dto => dto.Description)
            .NotEmpty().WithMessage("Description is required")
            .MinimumLength(5).WithMessage("Description should be minimum 5 characters length")
            .MaximumLength(20).WithMessage("Description should be maximum 20 characters length");

        RuleFor(dto => dto.Name)
            .NotEmpty().WithMessage("Name is required")
            .MinimumLength(2).WithMessage("Name must be minimum 2 characters length")
            .MaximumLength(20).WithMessage("Name must be maximum 20 characters length")
            .Custom((name, validationContext) =>
            {
                var carWorkshop = _carWorkshopRepository.FindByName(name).Result;
                if (carWorkshop != null)
                {
                    validationContext.AddFailure($"CarWorkshop with name {name} already exists");
                }
            });
    }
    
}