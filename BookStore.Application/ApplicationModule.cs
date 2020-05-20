using BookStore.Application.UseCases.Commands.CreateBook;
using BookStore.Application.UseCases.Queries.ListBook;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BookStore.Application
{
    public static class ApplicationModule
    {
        public static void ConfigureHandlers(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
