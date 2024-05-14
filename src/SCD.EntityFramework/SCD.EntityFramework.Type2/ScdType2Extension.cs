using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace SCD.EntityFramework.Type2;

public class ScdType2Extension : IDbContextOptionsExtension
{
    public void ApplyServices(IServiceCollection services)
    {
        
    }

    public void Validate(IDbContextOptions options)
    {
        
    }

    public DbContextOptionsExtensionInfo Info { get; }
}