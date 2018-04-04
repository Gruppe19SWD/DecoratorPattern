using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Tea : IDrink
    {
        public double GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Tea";
        }
    }
}
