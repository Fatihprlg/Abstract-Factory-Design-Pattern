using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class AmericanExpressCardFactory : CardFactory
    {
        public Card CreateCard()
        {
            return new AmericanExpress();
        }

           
    }
}
