using System;

namespace Task3
{
    class CappuccinoBuilder : CoffeeBuilder
    {
        public CappuccinoBuilder()
        {
            _coffee = new Coffee("Cappuccino");
        }
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Boiling water");
            _coffee.Add("water");
        }
        public override void SetSugar()
        {
            Console.WriteLine("Step 2 : Adding white sugar");
            _coffee.Add("white sugar");
        }
        public override void SetCoffeeQuantity()
        {
            Console.WriteLine("Step 3 : Adding two teaspoons of coffee powder");
            _coffee.Add("coffee");
        }
        public override void SetAdditionalIngredient()
        {
            Console.WriteLine("Step 4 : Adding milk");
            _coffee.Add("milk");
        }
        public override void SetCream()
        {
            // don't do anything, cappuccino doesn't have cream.
        }
        public override Coffee GetResult()
        {
            return _coffee;
        }
    }
}