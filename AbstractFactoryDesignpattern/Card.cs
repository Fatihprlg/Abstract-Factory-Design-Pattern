using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignpattern
{
    public abstract class Card
    {
        public string Owner { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ulong Number { get; set; }
        public int SecondDigit
        {
            get
            {
                return Convert.ToInt32(Number.ToString().Substring(1, 2));
            }
        }
        public int Length { get { return Convert.ToInt32(Number.ToString().Length); } }
        public abstract string getCardInfo();
    }
}
