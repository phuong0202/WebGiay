using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Mapping;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Data.Repository;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            
            // Application Layer
            services.AddScoped<ISanPhamService, SanPhamService>();

            // Infrastructure.Data
            services.AddScoped<ISanPhamRepository, SanPhamRepository>();

            // Application Layer
            services.AddScoped<IKhachHangService, KhachHangService>();

            // Infrastructure.Data
            services.AddScoped<IKhachHangRepository, KhachHangRepository>();

            // Application Layer
            services.AddScoped<IHoaDonService, HoaDonService>();

            // Infrastructure.Data
            services.AddScoped<IHoaDonRepository, HoaDonRepository>();

            


        }
    }
}
