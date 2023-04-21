using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Repository
{
    public class DbCoinInfo : ICoinInfo
    {
        private CoffeeContext context;
        static object lo = new object();
        public DbCoinInfo(CoffeeContext context)
        {
            this.context = context;
        }

        public int AddCoin(Coin coin)
        {
            context.Coins.Add(coin);
            context.SaveChanges();
            return coin.Id;
        }

        public int AddCoins(int coinId, int count)
        {
            lock (lo)
            {
                var coin = GetCoin(coinId) ?? throw new KeyNotFoundException();
                coin.Count += count;
                context.SaveChanges();
                return coin.Count;
            }
        }

        public Coin GetCoin(int id)
        {
            return context.Coins.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Coin> GetCoins()
        {
            return context.Coins.ToList();
        }

        public ChangeInfo GetChange(float value)
        {
            ChangeInfo changeInfo = new ChangeInfo();
            changeInfo.Balance = value;
            while (changeInfo.Balance > 0)
            {
                lock (lo)
                {
                    var c = context.Coins.Where(c => c.Count > 0 && c.Value <= changeInfo.Balance).OrderByDescending(t => t.Value).FirstOrDefault();
                    if (c == null) break;
                    var delt = (int)changeInfo.Balance / (int)c.Value;
                    if (delt > c.Count) delt = c.Count;
                    changeInfo.Balance -= c.Value * delt;
                    changeInfo.CoinConts[c] = delt;
                    c.Count -= delt;
                    context.SaveChanges();
                }

            }
            return changeInfo;
        }

        public int SetCoin(Coin coin)
        {
            lock (context)
            {
                var coinTmp = GetCoin(coin.Id) ?? throw new KeyNotFoundException();
                context.Entry(coinTmp).State = EntityState.Detached;
                context.Attach(coin).State = EntityState.Modified;
                context.SaveChanges();
                return coin.Id;
            }
        }

        public void DelCoin(int coinId)
        {
            lock (context)
            {
                var coinTmp = GetCoin(coinId) ?? throw new KeyNotFoundException();
                context.Coins.Remove(coinTmp);
                context.SaveChanges();               
            }          
        }
    }
}
