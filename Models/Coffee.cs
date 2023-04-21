using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CoffeeShop.Models
{
    [Index(nameof(Name), IsUnique = true, Name = "ui_coffee_name")]
    public class Coffee
    {
        [Column("id")]
        [DisplayName("Ид.")]
        public int Id { get; set; }
        [Column("name")]
        [DisplayName("Название")]
        public string Name { get; set; }
        [Column("descr")]
        [DisplayName("Описание")]
        public string Description { get; set; }
        [Column("price")]
        [DisplayName("Цена")]
        public float Price { get; set; }
        [Column("count")]
        [DisplayName("Остаток")]
        public int Count { get; set; }
        [Column("img")]
        [DisplayName("Изображение")]
        public string Img { get; set; }
    }
}
