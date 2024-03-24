using CarWorkshop.Domain.Interfaces;

namespace CarWorkshop.Application.Services;

public class CarWorkshopService: ICarWorkshopService
{
    private readonly ICarWorkshopRepository _repository;

    public CarWorkshopService(ICarWorkshopRepository repository)
    {
        _repository = repository;
    }
    
    public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
    {
        await _repository.Create(carWorkshop);
    }
}