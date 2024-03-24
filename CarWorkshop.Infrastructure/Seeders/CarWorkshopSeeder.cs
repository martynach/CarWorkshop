using CarWorkshop.Domain.Entities;
using CarWorkshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Seeders;

public class CarWorkshopSeeder
{
    private readonly CarWorkshopDbContext _dbContext;

    public CarWorkshopSeeder(CarWorkshopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Seed()
    {
        Console.WriteLine("Start seeding!");
        if (!await _dbContext.Database.CanConnectAsync())
        {
            Console.WriteLine("Cannot connect to database!");
            return;
        }

        if (!_dbContext.CarWorkshop.Any())
        {
            Console.WriteLine("CarWorkshop table is empty. Initializing with some data.");
            var carWorkshops = GetCarWorkshops();
            _dbContext.CarWorkshop.AddRange(carWorkshops);
            await _dbContext.SaveChangesAsync();
            Console.WriteLine("CarWorkshop table successfully initialized with some data");

        }
        
      
    }
    
    private IEnumerable<Domain.Entities.CarWorkshop> GetCarWorkshops()
    {
        var carWorkshops = new List<Domain.Entities.CarWorkshop>()
        {
            new()
            {
                Name = "Mar & Tom",
                Description = "Family workshop",
                ContactDetails = new CarWorkshopContactDetails
                    { 
                        City = "krakow",
                        PostalCode = "45-765",
                        PhoneNumber = "435-543-5687",
                        Street = "Olszewskiego"
                    }
            },
            new ()
            {
                Name = "Car trucks and more",
                ContactDetails = new CarWorkshopContactDetails
                {
                    City = "krakow",
                    PostalCode = "22-222",
                    PhoneNumber = "222-222-222"
                }
            }
        };
        return carWorkshops;
    }
}