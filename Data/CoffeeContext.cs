using CoffeeShop.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace CoffeeShop.Data
{
    public class CoffeeContext : DbContext
    {
        const String Fn = "coffee.db";

        private SqliteConnection connection;

        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Coin> Coins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options
           //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
           .UseSqlite(this.connection);

        public CoffeeContext()
        {
            var connectionString = $"Data Source={Fn}";
            this.connection = new SqliteConnection(connectionString);
            this.connection.CreateFunction<string, string>("lower", (string s) => s?.ToLower(), true);

            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coin>().HasData(new Coin() { Id = 1, Name = "1 Рубль", Value = 1, Count = 10_000 });
            modelBuilder.Entity<Coin>().HasData(new Coin() { Id = 2, Name = "2 Рубля", Value = 2, Count = 10_000, Active = false });
            modelBuilder.Entity<Coin>().HasData(new Coin() { Id = 3, Name = "5 Рублей", Value = 5, Count = 10_000 });
            modelBuilder.Entity<Coin>().HasData(new Coin() { Id = 4, Name = "10 Рублей", Value = 10, Count = 10_000 });

            modelBuilder.Entity<Coffee>().HasData(new Coffee() { Id = 1, Count = 100, Name = "Доппио", Img = "1.jpg", Price = 130, Description= "готовится как двойная порция эспрессо, две закладки кофе и два объема воды." });
            modelBuilder.Entity<Coffee>().HasData(new Coffee() { Id = 2, Count = 100, Name = "Американо", Img = "2.jpg", Price = 80, Description= "эспрессо обычный или двойной, в который после приготовления добавили (30–470 мл) горячей воды." });
            modelBuilder.Entity<Coffee>().HasData(new Coffee() { Id = 3, Count = 100, Name = "Ристретто", Img = "3.jpg", Price = 180, Description = "спрессо заваренный из того же количества кофе и за то же время экстракции, но с использованием вдвое меньшего количества воды." });
            modelBuilder.Entity<Coffee>().HasData(new Coffee() { Id = 4, Count = 100, Name = "Лунго", Img = "4.jpg", Price = 160, Description= "похож на Американо по пропорции воды к кофе. Однако, этот объем воды используется при заваривании (пропускается через кофе), в противоположность Американо, где вода заливается в готовый эспрессо." });
            modelBuilder.Entity<Coffee>().HasData(new Coffee() { Id = 5, Count = 100, Name = "Кафе крема", Img = "5.jpg", Price = 200, Description= " еще более длинный Лунго. До 50-х годов caffe crema называли эспрессо." });
            modelBuilder.Entity<Coffee>().HasData(new Coffee() { Id = 6, Count = 100, Name = "Эспресс", Img = "6.jpg", Price = 150, Description = "напиток приготовленный с помощью рожковой эспрессо-машины. Принципиальные различия во вкусе достигаются благодаря более длительному времени экстракции" });

        }
    }
}
