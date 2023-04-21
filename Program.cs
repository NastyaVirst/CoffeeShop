using CoffeeShop.Data;
using CoffeeShop.Repository;
using Tewr.Blazor.FileReader;

namespace CoffeeShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddDbContext<CoffeeContext>();
            builder.Services.AddScoped<ICoinInfo, DbCoinInfo>();
            builder.Services.AddScoped<ICoffeeInfo, DbCoffeeInfo>();
            builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}