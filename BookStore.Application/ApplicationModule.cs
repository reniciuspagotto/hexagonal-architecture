using BookStore.Application.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Application
{
    public static class ApplicationModule
    {
        public static void ConfigureHandlers(this IServiceCollection services)
        {
            services.AddTransient<IBookHandler, BookHandler>();
        }
    }
}
