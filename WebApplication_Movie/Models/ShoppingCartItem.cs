using System.ComponentModel.DataAnnotations;

namespace WebApplication_Movie.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
