namespace CoffeeShop.Models
{
    public class ChangeInfo
    {
        public Dictionary<Coin, int> CoinConts { get; } = new Dictionary<Coin, int>(); 
        public float Balance { get; set; }
        public string CoinContsText() => string.Join("; ", CoinConts.Select(t => $"{t.Key.Name}-{t.Value}шт."));
        
    }
}
