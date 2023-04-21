using CoffeeShop.Models;

namespace CoffeeShop.Repository
{
    public interface ICoffeeInfo
    {
        IEnumerable<Coffee> GetCoffeeList();
        Coffee GetCoffee(int id);
        int ChangeCoffeeCount(int coinId, int count);
        int AddCoffee(Coffee coin);
        int SetCoffee(Coffee coin);
        void DelCoffee(int id);
    }
}
