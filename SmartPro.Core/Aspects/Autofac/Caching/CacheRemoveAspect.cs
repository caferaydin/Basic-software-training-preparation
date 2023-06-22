using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using SmartPro.Core.CrossCuttingConcerns.Caching;
using SmartPro.Core.Utilities.Interceptors;
using SmartPro.Core.Utilities.IoC;

namespace SmartPro.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
