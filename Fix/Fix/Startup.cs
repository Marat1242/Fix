    using Fix.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using FluentAssertions.Common;

namespace Fix
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
            {
        string connection = Configuration.GetConnectionString("DefaultConnection");
        // добавляем контекст ApplicationContext в качестве сервиса в приложение
        services.AddDbContext<EFDbContext>(options =>
                options.UseSqlServer(connection));
            services.AddControllersWithViews();
            }
    }
}
