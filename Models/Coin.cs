using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CoffeeShop.Models
{
    public class Coin
    {
        [Column("id")]
        [DisplayName("Ид.")]
        public int Id { get; set; }
        [Column("name")]
        [DisplayName("Название")]
        public string Name { get; set; }
        [Column("value")]
        [DisplayName("Номинал")]
        public float Value { get; set; }
        [Column("count")]
        [DisplayName("В хранилище")]
        public int Count { get; set; }

        [Column("active")]
        [DisplayName("Доступно для приема")]
        public bool Active { get; set; } = true;
    }
}
