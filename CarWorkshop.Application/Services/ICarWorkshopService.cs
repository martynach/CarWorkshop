namespace CarWorkshop.Application.Services;

public interface ICarWorkshopService
{
    public Task Create(Domain.Entities.CarWorkshop carWorkshop);

}