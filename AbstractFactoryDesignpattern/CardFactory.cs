using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    interface CardFactory
    {
        public Card CreateCard();
    }
}
