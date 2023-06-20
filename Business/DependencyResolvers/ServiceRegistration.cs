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

namespace SmartPro.Business.DependecyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceRegistration(this IServiceCollection services)
        {
            services.AddSingleton<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICategoryService, CategoryManager>();

            services.AddSingleton<ISubCategoryDal, EfSubCategoryDal>();
            services.AddSingleton<ISubCategoryService, SubCategoryManager>();

            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IBrandService, BrandManager>();

            services.AddSingleton<IProductDal, EfProductDal>();
            services.AddSingleton<IProductService, ProductManager>();
        }
    }
}
