using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OGANI.CartService.Infrastructure.Persistance;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using OGANI.CartService.Domain.Interfaces;
using OGANI.CartService.Infrastructure.Repositories;

namespace OGANI.CartService.Infrastructure.Extensions
{
	public static class ServiceCollectionExtensions
	{
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OganiDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DbContext") ?? "")
                    .EnableSensitiveDataLogging());
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IWishlistRepository,WishlistRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


        }
    }
}

