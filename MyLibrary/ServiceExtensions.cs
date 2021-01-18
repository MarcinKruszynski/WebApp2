using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using AutoMapper;

namespace MyLibrary
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<IWeatherForecastService, WeatherForecastService>();
        }
    }
}
