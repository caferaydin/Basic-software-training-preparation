using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using SmartPro.DataAccess.Configurations;
using SmartPro.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddRegistrationService(this IServiceCollection services)
        {
            //services.AddDbContext<MsSqlDbContext>(option => option.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
