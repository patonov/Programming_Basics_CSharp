﻿using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());

            double budget = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int daysCounter = 0;

            while (budget < moneyNeeded)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                switch (action)
                {
                    case ("spend"):
                        spendCounter++;
                        budget -= money;
                        if (budget < 0)
                        {
                            budget = 0;
                        }
                        break;
                    case ("save"):
                        budget += money;
                        spendCounter = 0;
                        break;
                }
                daysCounter++;

                if (spendCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine("{0}", daysCounter);
                    break;
                }
            }
            if (spendCounter != 5)
            {
                Console.WriteLine("You saved the money for {0} days.", daysCounter);
            }
        }
    }
}
