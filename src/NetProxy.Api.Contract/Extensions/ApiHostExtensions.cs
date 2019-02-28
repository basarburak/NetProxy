using Microsoft.Extensions.DependencyInjection;
using NetProxy.Api.Contract.Services;
using System;

namespace NetProxy.Api.Contract.Extensions
{
    public static class ApiHostExtensions
    {
        public static IServiceCollection AddProxy(this IServiceCollection services)
        {
            services.AddHttpClient(ApiConstant.ApiName, client =>
            {
                client.BaseAddress = new Uri(ApiConstant.ApiAdress);
            });

            services.AddScoped<IProductService, ProductApi>();

            return services;
        }
    }
}
