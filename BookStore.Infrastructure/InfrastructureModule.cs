using BookStore.Domain.Repositories;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure
{
    public static class InfrastructureModule
    {
        public  static void ConfigureDatabase(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: "BookStore"));
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBookRepository, BookRepository>();
        }
    }
}
