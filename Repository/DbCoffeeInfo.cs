using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Repository
{
    public class DbCoffeeInfo : ICoffeeInfo
    {
        private CoffeeContext context;
        static object lo = new object();
        public DbCoffeeInfo(CoffeeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Coffee> GetCoffeeList()
        {
            return context.Coffees.ToList();
        }

        public Coffee GetCoffee(int id)
        {
            return context.Coffees.FirstOrDefault(c => c.Id == id);
        }

        public int ChangeCoffeeCount(int coffeeId, int count)
        {
            lock (lo)
            {
                var coffee = GetCoffee(coffeeId) ?? throw new KeyNotFoundException();
                coffee.Count += count;
                context.SaveChanges();
                return coffee.Count;
            }
        }

        public int AddCoffee(Coffee coffee)
        {
            context.Coffees.Add(coffee);
            context.SaveChanges();
            return coffee.Id;
        }

        public int SetCoffee(Coffee coffee)
        {
            lock (context)
            {
                var coffeeTmp = GetCoffee(coffee.Id) ?? throw new KeyNotFoundException();
                context.Entry(coffeeTmp).State = EntityState.Detached;
                context.Attach(coffee).State = EntityState.Modified;
                context.SaveChanges();
                return coffee.Id;
            }
        }

        public void DelCoffee(int id)
        {
            lock (context)
            {
                var coffeeTmp = GetCoffee(id) ?? throw new KeyNotFoundException();
                context.Coffees.Remove(coffeeTmp);
                context.SaveChanges();
            }
        }
    }
}
