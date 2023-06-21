using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using SmartPro.Business.Abstraction;
using SmartPro.Business.Abstraction.Auth;
using SmartPro.Business.Concrete;
using SmartPro.Business.Concrete.Auth;
using SmartPro.Core.Utilities.Interceptors;
using SmartPro.Core.Utilities.Security.JWT;
using SmartPro.DataAccess.Abstraction;
using SmartPro.DataAccess.Concrete.EntityFramework;

namespace SmartPro.Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<SubCategoryManager>().As<ISubCategoryService>();
            builder.RegisterType<EfSubCategoryDal>().As<ISubCategoryDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
