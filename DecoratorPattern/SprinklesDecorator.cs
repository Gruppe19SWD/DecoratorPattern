using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SprinklesDecorator : DrinkDecorator
    {
        public SprinklesDecorator(IDrink iDrink) : base(iDrink)
        {
            _name = "sprinkles";
            _price = 0.5;
        }

        public override string GetDescription()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return base.GetDescription() + " WUHUU SPRINKLES";
            
        }
       

    }
}
