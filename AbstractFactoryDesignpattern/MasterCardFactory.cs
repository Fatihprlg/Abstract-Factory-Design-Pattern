using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class MasterCardFactory : CardFactory
    {
        public Card CreateCard()
        {
            return new MasterCard();
        }

    }
}
