using CoffeeShop.Models;

namespace CoffeeShop.Repository
{
    public interface ICoinInfo
    {
        IEnumerable<Coin> GetCoins();
        Coin GetCoin(int id);
        int AddCoins(int coinId, int count);
        int AddCoin(Coin coin);
        int SetCoin(Coin coin);
        void DelCoin(int coinId);
        ChangeInfo GetChange(float value);

    }
}
