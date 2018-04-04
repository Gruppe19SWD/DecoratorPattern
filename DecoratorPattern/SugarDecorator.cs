using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SugarDecorator : DrinkDecorator
    {
        public SugarDecorator(IDrink iDrink) : base(iDrink)
        {
            _name = "Sugar";
            _price = 1.5;
        }
    }
}
