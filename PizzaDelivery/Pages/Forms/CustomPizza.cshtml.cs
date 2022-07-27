using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaDtoModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            //it should be the call with selected ingredients to service which will give the price based on ingredients
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 1;

            Pizza.Name = "Custom";
            Pizza.ImageTitle = "Create";

            return RedirectToPage("/Checkout/Checkout",new {Pizza.Name, PizzaPrice, Pizza.ImageTitle});
        }
    }
}
