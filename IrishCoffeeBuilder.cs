using System;

namespace Task3
{
    class IrishCoffeeBuilder : CoffeeBuilder
    {
        public IrishCoffeeBuilder()
        {
            _coffee = new Coffee("Irish Coffee");
        }
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            _coffee.Add("water");
        }
        public override void SetSugar()
        {
            Console.WriteLine("Step 2 : Adding brown sugar");
            _coffee.Add("brown sugar");
        }
        public override void SetCoffeeQuantity()
        {
            Console.WriteLine("Step 3 : Adding three teaspoons of coffee powder");
            _coffee.Add("coffee");
        }
        public override void SetAdditionalIngredient()
        {
            Console.WriteLine("Step 4 : Adding Irish whiskey");
            _coffee.Add("Irish whiskey");
        }
        public override void SetCream()
        {
            Console.WriteLine("Step 5 : Adding fresh cream");
            _coffee.Add("fresh cream");
        }
        public override Coffee GetResult()
        {
            return _coffee;
        }
    }
}