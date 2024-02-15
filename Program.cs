using Microsoft.EntityFrameworkCore;
using ZeissRestWebServiceDemo.Context;
using ZeissRestWebServiceDemo.Services;

namespace ZeissRestWebServiceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContext<BookContext>(options =>
            {
                options.UseSqlite("Data Source=books.db");
            });

            builder.Services.AddScoped<IBookService, BookService>();

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
