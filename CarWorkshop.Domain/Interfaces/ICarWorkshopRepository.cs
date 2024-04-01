namespace CarWorkshop.Domain.Interfaces;

public interface ICarWorkshopRepository
{
    public Task Create(Entities.CarWorkshop carWorkshop);
    public Task<Entities.CarWorkshop?> FindByName(string name);

}