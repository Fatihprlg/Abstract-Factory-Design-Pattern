using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class VisaCardFactory : CardFactory
    {
        public Card CreateCard()
        {
            return new Visa();
        }

    }
}
