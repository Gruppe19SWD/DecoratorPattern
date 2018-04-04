using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class DrinkDecorator : IDrink
    {
        private IDrink _idrink;
        protected string _name = "Undefined";
        protected double _price = 0.0;

        public DrinkDecorator(IDrink idrink)
        {
            _idrink = idrink;
        }

        public double GetCost()
        {
            return _idrink.GetCost() + _price;
        }
            
        public string GetDescription()
        {
            return string.Format("{0},{1}", _idrink.GetDescription(), _name);
        }


    }
}
