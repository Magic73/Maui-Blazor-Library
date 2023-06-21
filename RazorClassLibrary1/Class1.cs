using Microsoft.Extensions.DependencyInjection;

using MudBlazor.Services;

using RazorClassLibrary1.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddMudServices();

            services.AddSingleton<WeatherForecastService>();

            return services;
        }
    }
}
