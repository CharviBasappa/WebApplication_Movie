using Microsoft.AspNetCore.Mvc;
using WebApplication_Movie.Data.Cart;

namespace WebApplication_Movie.Data.ViewComponents
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems()
                .Sum(item => item.Amount);

            return View(items);
        }
    }
}
