using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SCD.EntityFramework.Type2;

public static class ScdType2DbContextOptionsExtensions
{
    public static DbContextOptionsBuilder UseScdType2(this DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder is null)
        {
            throw new ArgumentNullException(nameof(optionsBuilder));
        }

        // Check, whether the scd extension has already been added and if not it will add it.
        var extension = optionsBuilder.Options.FindExtension<ScdType2Extension>() ?? new ScdType2Extension();
        ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(extension);
        
        return optionsBuilder;
    }
}