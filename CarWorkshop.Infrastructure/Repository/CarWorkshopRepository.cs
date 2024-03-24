using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistence;

namespace CarWorkshop.Infrastructure.Repository;

public class CarWorkshopRepository: ICarWorkshopRepository
{
    private readonly CarWorkshopDbContext _dbContext;

    public CarWorkshopRepository(CarWorkshopDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
    {
        await _dbContext.CarWorkshop.AddAsync(carWorkshop);
        await _dbContext.SaveChangesAsync();
    }
}