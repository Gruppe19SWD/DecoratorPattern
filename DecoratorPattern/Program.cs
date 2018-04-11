using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var testKaffe = new SugarDecorator(new MilkDecorator(new Coffee()));


            Console.WriteLine(testKaffe.GetDescription());
            Console.WriteLine(testKaffe.GetCost());

            var testKaffeasd = new SprinklesDecorator(testKaffe);
            Console.WriteLine(testKaffeasd.GetDescription());
            Console.WriteLine(testKaffeasd.GetCost());
            var doubleSprinkles = new SprinklesDecorator(testKaffeasd);
            Console.WriteLine(doubleSprinkles.GetDescription());
            Console.WriteLine(doubleSprinkles.GetCost());
            

            Console.ForegroundColor = ConsoleColor.White;
            //test of adding behaviour at runtime
            Console.WriteLine("If you want a Tea, press T. if you want a Coffee, press C. This resets the order though");
            Console.WriteLine("test of adding behaviour at runtime(you have to press the buttons twice), press M to add milk, press S to add sugar and press W to add sprinkles. for wauw effect.");
            IDrink DrinkTest = new Coffee();

            //ConsoleKeyInfo read1 = Console.ReadKey();
            do
            {
                ConsoleKeyInfo read = Console.ReadKey();
                if (read.Key == ConsoleKey.M)
                {
                    DrinkTest = new MilkDecorator(DrinkTest);
                }
                if (read.Key == ConsoleKey.S)
                {
                    DrinkTest = new SugarDecorator(DrinkTest);
                    
                }
                if (read.Key == ConsoleKey.W)
                {
                    DrinkTest = new SprinklesDecorator(DrinkTest);    
                }
                if (read.Key == ConsoleKey.C)
                {
                    DrinkTest = new Coffee();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (read.Key == ConsoleKey.T)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    DrinkTest = new Tea();
                }


                Console.WriteLine();
                Console.WriteLine(DrinkTest.GetDescription());
                Console.WriteLine(DrinkTest.GetCost());
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            
        }
    }
}
