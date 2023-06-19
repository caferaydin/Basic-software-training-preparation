using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartPro.Business.Abstraction;
using SmartPro.Business.Concrete;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Concrete.EntityFramework;
using SmartPro.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ISubCategoryDal, EfSubCategoryDal>();
            services.AddScoped<ISubCategoryService, SubCategoryManager>();

            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IBrandService, BrandManager>();

            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();
        }
    }
}
