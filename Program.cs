using ZeissRestWebServiceDemo.Services;

namespace ZeissRestWebServiceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IBookService, BookService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.


            app.MapControllers();

            app.Run();
        }
    }
}
