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
            Console.ReadLine();

        }
    }
}
