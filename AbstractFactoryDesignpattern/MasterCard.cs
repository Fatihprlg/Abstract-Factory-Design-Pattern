using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    class MasterCard : Card
    {
        public readonly string CARD_TYPE = "MasterCard";
        public static readonly int FIRST_DIGIT = 5;
        public override string getCardInfo()
        {
            return CARD_TYPE + " " + Number + " " + Owner + " " + ExpirationDate.ToString("MM/yy"); 
        }
    }
}
