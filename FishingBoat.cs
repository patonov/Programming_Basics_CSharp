﻿using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double currentPrice = 0;
            double finalCurrentPrice = 0;

            if (season == "Spring")
            {
                if (fishers <= 6)
                {
                    currentPrice = 3000 - (3000 * 0.1);
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    currentPrice = 3000 - (3000 * 0.15);
                }
                else if (fishers > 11)
                {
                    currentPrice = 3000 - (3000 * 0.25);
                }
            }

            else if (season == "Summer")
            {
                if (fishers <= 6)
                {
                    currentPrice = 4200 - (4200 * 0.1);
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    currentPrice = 4200 - (4200 * 0.15);
                }
                else if (fishers >= 12)
                {
                    currentPrice = 4200 - (4200 * 0.25);
                }

            }

            else if (season == "Autumn")
            {
                if (fishers <= 6)
                {
                    currentPrice = 4200 - (4200 * 0.1);
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    currentPrice = 4200 - (4200 * 0.15);
                }
                else if (fishers >= 12)
                {
                    currentPrice = 4200 - (4200 * 0.25);
                }
            }
            else if (season == "Winter")
            {
                if (fishers <= 6)
                {
                    currentPrice = 2600 - (2600 * 0.1);
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    currentPrice = 2600 - (2600 * 0.15);
                }
                else if (fishers >= 12)
                {
                    currentPrice = 2600 - (2600 * 0.25);
                }
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                finalCurrentPrice = currentPrice - currentPrice * 0.05;
            }
            else
            {
                finalCurrentPrice = currentPrice;
            }

            if (budget > finalCurrentPrice)
            {
                double moneyLeft = budget - finalCurrentPrice;
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
            else if (budget < finalCurrentPrice)
            {
                double moneyNeeded = finalCurrentPrice - budget;
                Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyNeeded);
            }
        }
    }
}
