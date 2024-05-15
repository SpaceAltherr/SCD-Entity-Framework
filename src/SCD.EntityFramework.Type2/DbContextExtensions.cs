using Microsoft.EntityFrameworkCore;
using SCD.EntityFramework.Type2.Model;

namespace SCD.EntityFramework.Type2;

public static class DbContextExtensions
{
    public static void EnsureScdType2(this DbContext dbContext) => EnsureScdType2<Guid>(dbContext);

    public static void EnsureScdType2<TKeyType>(this DbContext dbContext)
    {
        var entries = dbContext.ChangeTracker.Entries<IScdType2Model<TKeyType>>()
            .Where(e => e.State == EntityState.Added
                        || e.State == EntityState.Modified
                        || e.State == EntityState.Deleted).ToArray();

        foreach (var entry in entries)
        {
            
        }
    }
}