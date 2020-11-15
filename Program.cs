using System.IO;
using System;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                CoffeeDirector coffeeDirector1 = new CoffeeDirector();

                CoffeeBuilder cappuccinoBuilder = new CappuccinoBuilder();

                coffeeDirector1.Construct(cappuccinoBuilder);

                Coffee coffee = cappuccinoBuilder.GetResult();

                Console.WriteLine("Cappuccino coffee {0}: {1}", i+1 , coffee);
                Console.WriteLine();
            }

            for(int j = 0; j < 2; j++)
            {
                CoffeeDirector coffeeDirector2 = new CoffeeDirector();

                CoffeeBuilder irishCoffeeBuilder = new IrishCoffeeBuilder();

                coffeeDirector2.Construct(irishCoffeeBuilder);

                Coffee coffee = irishCoffeeBuilder.GetResult();

                Console.WriteLine("Irish coffee {0}: {1}", j+1 , coffee);
                
                Console.WriteLine();
            }
        }

    }

}
