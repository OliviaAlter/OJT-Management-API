using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ojt_management_api.Data;
using ojt_management_api.Interfaces;
using ojt_management_api.Services;

namespace ojt_management_api.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<ITokenServices, TokenServices>();
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("TotallyNotAConnectionStringOverHere"));
        });
        return services;
    }
}