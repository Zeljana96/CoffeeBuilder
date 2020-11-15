namespace Task3
{
    internal class CoffeeDirector
    {
        public void Construct (CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.SetWater();
            coffeeBuilder.SetSugar();
            coffeeBuilder.SetCoffeeQuantity();
            coffeeBuilder.SetAdditionalIngredient();
            coffeeBuilder.SetCream();
            
        }
    }
}