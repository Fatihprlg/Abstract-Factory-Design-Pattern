using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class AmericanExpress : Card
    {
        public readonly string CARD_TYPE = "AmericanExpress";
        public static readonly int FIRST_DIGIT = 3;
        public override string getCardInfo()
        {
            return CARD_TYPE + " " + Number + " " + Owner + " " + ExpirationDate.ToString("MM/yy");
        }
    }
}
