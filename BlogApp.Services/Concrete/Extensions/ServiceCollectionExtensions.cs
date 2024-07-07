using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Entities.Concrete;
using BlogApp.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Concrete.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService (this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BlogAppContext>();

            serviceCollection.AddIdentity<User,Role>(options =>
            {
                // User Password Options
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

                // User Username and Email Options
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+!";
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<BlogAppContext>();

            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            serviceCollection.AddScoped<ICategoryService, CategoryManager>();

            serviceCollection.AddScoped<IArticleService, ArticleManager>();

            return serviceCollection;
        }
    }
}
