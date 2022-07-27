namespace PizzaDelivery.Models
{
    public class PizzaDtoModel
    {
        public string ImageTitle { get; set; }
        public string Name { get; set; }
        public float BasePrice { get; set; } = 2;

        //there should be Pizza and Ingredients models also to manage them as objects
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }
    }
}
