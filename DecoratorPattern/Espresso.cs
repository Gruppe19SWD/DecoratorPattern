using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Espresso : IDrink
    {
        public double GetCost()
        {
            return 15;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
