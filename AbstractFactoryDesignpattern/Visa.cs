using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class Visa : Card
    {
        public readonly string CARD_TYPE = "Visa";
        public static readonly int FIRST_DIGIT = 4;
        public override string getCardInfo()
        {
            return CARD_TYPE + " " + Number + " " + Owner + " " + ExpirationDate.ToString("MM/yy");
        }
    }
}
