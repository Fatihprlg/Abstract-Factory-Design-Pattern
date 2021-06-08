using System;
using System.Collections.Generic;
using System.IO;

namespace AbstractFactoryDesignpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\DummyData.txt";
            List<string> data = new List<string>();
            txtFileOps file = new txtFileOps();
            data.Add("5353535353535353 Fatih_Parlagi 04/2024");
            data.Add("4646464646464 Orhan_Parlagi 06/2026");
            data.Add("375646464646435 Zeliha_Parlagi 06/2026");
            data.Add("275646464646435 Zeliha_Parlagi 06/2026");

            file.WriteFile(filePath, data);
            List<string> records = file.ReadFile(filePath);
            records.ForEach(x =>
            {
                string[] line = x.Split(' ');
                int SecondDigit = Convert.ToInt32(line[0].Substring(1, 1));
                if (line[0].Length == 16)
                {
                    if (line[0].StartsWith(MasterCard.FIRST_DIGIT.ToString()) && (SecondDigit < 5 && SecondDigit > 1 ))
                    {
                        MasterCardFactory masterCard = new MasterCardFactory();
                        Card card = masterCard.CreateCard();
                        card.Number = Convert.ToUInt64(line[0]);
                        card.Owner = line[1];
                        card.ExpirationDate = Convert.ToDateTime(line[2]);
                        Console.WriteLine(card.getCardInfo());
                    }
                    else if (line[0].StartsWith(Visa.FIRST_DIGIT.ToString()))
                    {
                        VisaCardFactory visaCard = new VisaCardFactory();
                        Card card = visaCard.CreateCard();
                        card.Number = Convert.ToUInt64(line[0]);
                        card.Owner = line[1];
                        card.ExpirationDate = Convert.ToDateTime(line[2]);
                        Console.WriteLine(card.getCardInfo());
                    }
                    else
                    {
                        Console.WriteLine("Invalid card number : " + line[0]);
                    }
                }
                else if(line[0].Length == 13 && line[0].StartsWith(Visa.FIRST_DIGIT.ToString()))
                {
                        VisaCardFactory visaCard = new VisaCardFactory();
                        Card card = visaCard.CreateCard();
                        card.Number = Convert.ToUInt64(line[0]);
                        card.Owner = line[1];
                        card.ExpirationDate = Convert.ToDateTime(line[2]);
                        Console.WriteLine(card.getCardInfo());
                }
                else if(line[0].Length == 15 && line[0].StartsWith(AmericanExpress.FIRST_DIGIT.ToString()))
                {
                        AmericanExpressCardFactory americanExpressCard = new AmericanExpressCardFactory();
                        Card card = americanExpressCard.CreateCard();
                        card.Number = Convert.ToUInt64(line[0]);
                        card.Owner = line[1];
                        card.ExpirationDate = Convert.ToDateTime(line[2]);
                        Console.WriteLine(card.getCardInfo());

                }
                else
                {
                    Console.WriteLine("Invalid card number : " + line[0]);
                }
            });

        }
    }
}
