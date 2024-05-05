using System;
using Microsoft.Extensions.DependencyInjection;
using OGANI.CartService.Domain.Interfaces;

namespace OGANI.CartService.Application.Extensions
{
	public  static class ServiceCollectionExtensions
	{
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICartService, Services.CartService>();
            services.AddScoped<IWishlistService, Services.WishListService>();
            return services;
        }
    }
}

