namespace CarWorkshop.Domain.Interfaces;

public interface ICarWorkshopRepository
{
    public Task Create(Entities.CarWorkshop carWorkshop);

}