using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.ProductAgg;
using ShopManagement.Application.Contracts.ProductCategoryAgg;
using ShopManagement.Application.Contracts.ProductPictureAgg;
using ShopManagement.Application.Contracts.SlideAgg;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Domain.SlideAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;
using System;

namespace ShopManagementConfiguration
{
    public class ShopManagementBootstrapper
    {
        public static void Configur(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ShopManagement.Application.Contracts.ProductCategoryAgg.IProductPictureApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductPictureRepository, ProductPictureRepository>();
            services.AddTransient<ShopManagement.Application.Contracts.ProductPictureAgg.IProductPictureApplication, ProductPictureApplication>();

            services.AddTransient<ISlideRepository, SlideRepository>();
            services.AddTransient<ISlideApplication, SlideApplication>();

            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }

    }
}
