using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Persistence;

public class CarWorkshopDbContext: DbContext
{
    public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options): base(options)
    {
    }
    
    public DbSet<Domain.Entities.CarWorkshop> CarWorkshop { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Domain.Entities.CarWorkshop>().OwnsOne(cw => cw.ContactDetails);
        modelBuilder.Entity<Domain.Entities.CarWorkshop>().Property(cw => cw.Name).IsRequired();
        
    }

    // zmieniamy sposob rejestracji zaleznosci do konkretnej bazy danych
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     base.OnConfiguring(optionsBuilder);
    //     string _connectionString = "Host=localhost; Database=CarWorkshop; Username=postgres; Password=Krlnk213202!";
    //     optionsBuilder.UseNpgsql(_connectionString);
    //
    // }
}