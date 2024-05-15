using CarFactory.Database.CarParts;
using Microsoft.EntityFrameworkCore;

namespace CarFactory.Database;

public class CarFactoryDbContext : DbContext
{
    public DbSet<Chassis> Chassis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMongoDB("mongodb://mongoadmin:12345678@192.168.44.138", "carfactory");
        }

        base.OnConfiguring(optionsBuilder);
    }
}