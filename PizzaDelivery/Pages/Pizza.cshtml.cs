using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDelivery.Models;

namespace PizzaDelivery.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzaDtoModel> fakePizzaDb = new List<PizzaDtoModel>()
        {
            new PizzaDtoModel(){ImageTitle="Margerita", Name="Margerita", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzaDtoModel(){ImageTitle="Bolognese", Name="Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice=5},
            new PizzaDtoModel(){ImageTitle="Hawaiian", Name="Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Pineapple=true, FinalPrice=15},
            new PizzaDtoModel(){ImageTitle="MeatFeast", Name="MeatFeast", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Beef=true,Peperoni=true,FinalPrice=7},
            new PizzaDtoModel(){ImageTitle="Mushroom", Name="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, FinalPrice=5},
            new PizzaDtoModel(){ImageTitle="Pepperoni", Name="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, Peperoni=true, FinalPrice=5},
            new PizzaDtoModel(){ImageTitle="Seafood", Name="Seafood", BasePrice=2, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice=5},
            new PizzaDtoModel(){ImageTitle="Vegetarian", Name="Vegetarian", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, Pineapple=true, FinalPrice=15}
        };
        public void OnGet()
        {
        }


    }
}
