using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using qrmenuproject.Models;
using Repositories.Contracts;
using Repositories;
using Services.Contracts;
using Services;

namespace qrmenuproject.Infrastructe.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("sqlconnection"), b => b.MigrationsAssembly("qrmenuproject"));
                options.EnableSensitiveDataLogging(true);
            });
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(option =>
            {
                option.User.RequireUniqueEmail = true;
                option.Password.RequireDigit = true;
                option.Password.RequireUppercase = true;
                option.Password.RequireLowercase = true;
                option.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<RepositoryContext>();
        }
        public static void ConfigureRepositoryRegistration(this IServiceCollection services) 
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<ICafeContactInfoRepository, CafeContactInfoRepository>();
        }
        public static void ConfigureServicesRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<ICafeContactInfoService, CafeContactInfoManager>();
        }
    }
}
