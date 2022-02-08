using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 75, rubToEur = 85;
            int usdToRub = 77, usdToEur = 2;
            int eurToRub = 88, eurToUsd = 3;
            
            float rub;
            float usd;
            float eur;
            int userInput;
            float currencyCount;

            Console.WriteLine("Добро пожаловать в обменник валют. Валюты доступные для обмена: RUB, USD, EUR.");

            Console.Write("Введите баланс рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс евро: ");
            eur = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять рубли на евро");
            Console.WriteLine("3 - обменять доллары на рубли");
            Console.WriteLine("4 - обменять доллары на евро");
            Console.WriteLine("5 - обменять евро на рубли");
            Console.WriteLine("6 - обменять евро на доллары");
            userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("Обмен рублей на доллары.");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");
                    }
                    break;
                
                case 2:
                    Console.Write("Обмен рублей на евро.");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        eur += currencyCount / rubToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");
                    }
                    break;

                case 3:
                    Console.Write("Обмен долларов на рубли.");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");
                    }
                    break;

                case 4:
                    Console.Write("Обмен долларов на евро.");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        eur += currencyCount / usdToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");
                    }
                    break;

                case 5:
                    Console.Write("Обмен евро на рубли.");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount;
                        rub += currencyCount * eurToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");
                    }
                    break;

                case 6:
                    Console.Write("Обмен евро на доллары.");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount;
                        usd += currencyCount / eurToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во");
                    }
                    break;
            }

            Console.WriteLine("Ваш балан составляет: " + rub + " RUB "+ usd + " USD " + eur + " EUR. ");
        }

    }
}
