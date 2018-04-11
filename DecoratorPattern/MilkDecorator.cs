using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MilkDecorator : DrinkDecorator
    {
        public MilkDecorator(IDrink iDrink) : base(iDrink)
        {
            _name = "Milk";
            _price = 2;
            

        }
        
    }
}
