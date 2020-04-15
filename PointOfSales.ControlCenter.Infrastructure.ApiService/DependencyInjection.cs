using Microsoft.Extensions.DependencyInjection;
using PointOfSales.ControlCenter.Application.Interfaces;
using PointOfSales.ControlCenter.Infrastructure.ApiService.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSales.ControlCenter.Infrastructure.ApiService
{
    public static class DependencyInjection
    {
        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
        }
    }
}
