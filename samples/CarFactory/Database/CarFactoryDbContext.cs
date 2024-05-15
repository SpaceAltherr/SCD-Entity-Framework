using CarFactory.Database.CarParts;
using Microsoft.EntityFrameworkCore;
using SCD.EntityFramework.Type2;

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

    public override int SaveChanges()
    {
        this.EnsureScdType2();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        this.EnsureScdType2();
        return base.SaveChangesAsync(cancellationToken);
    }
}