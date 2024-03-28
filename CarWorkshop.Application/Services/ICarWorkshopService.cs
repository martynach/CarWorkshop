using CarWorkshop.Application.Dtos;

namespace CarWorkshop.Application.Services;

public interface ICarWorkshopService
{
    public Task Create(CarWorkshopDto carWorkshopDto);

}