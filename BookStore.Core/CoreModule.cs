using BookStore.Core.Business.BookService.CreateBook;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public static class CoreModule
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateBookUseCase, CreateBookUseCase>();
        }
    }
}
