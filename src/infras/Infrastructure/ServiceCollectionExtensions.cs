using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        string dbConnection) 
    {
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(dbConnection));
        return services;
    }
}