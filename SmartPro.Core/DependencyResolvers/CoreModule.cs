using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SmartPro.Core.CrossCuttingConcerns.Caching;
using SmartPro.Core.CrossCuttingConcerns.Caching.Microsoft;
using SmartPro.Core.Utilities.IoC;
using System.Diagnostics;

namespace SmartPro.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<Stopwatch>();
        }
    }
}
