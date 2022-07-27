using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Data;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThankYouModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }

        private readonly ApplicationDbContext _context;
        public ThankYouModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
