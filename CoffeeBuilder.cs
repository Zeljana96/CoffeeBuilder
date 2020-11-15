namespace Task3
{
    abstract class CoffeeBuilder
    {
        protected Coffee _coffee;

        public Coffee Coffee
        {
            get { return _coffee; }
        }

        public abstract void SetWater();

        public abstract void SetSugar();

        public abstract void SetCoffeeQuantity();

        public abstract void SetAdditionalIngredient();

        public abstract void SetCream();

        public abstract Coffee GetResult();

    }
}