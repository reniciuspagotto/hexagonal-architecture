using BookStore.Application.UseCases.Commands.CreateBook;
using BookStore.Application.UseCases.Queries.ListBook;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Application
{
    public static class ApplicationModule
    {
        public static void ConfigureHandlers(this IServiceCollection services)
        {
            services.AddTransient<ICreateBookHandler, CreateBookHandler>();
            services.AddTransient<IListBookHandler, ListBookHandler>();
        }
    }
}
