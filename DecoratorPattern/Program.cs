using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var testKaffe = new SugarDecorator(new MilkDecorator(new Espresso()));


            Console.WriteLine(testKaffe.GetDescription());

            var testKaffeasd = new SprinklesDecorator(testKaffe);
            Console.WriteLine(testKaffeasd.GetDescription());
            Console.ReadLine();

        }
    }
}
