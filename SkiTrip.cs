﻿using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedBack = Console.ReadLine();

            double price = 0;

            int nights = days - 1;

            if (roomType == "apartment")
            {
                if (nights < 10)
                {
                    price = nights * 25 - (nights * 25 * 0.3);
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price = nights * 25 - (nights * 25 * 0.35);
                }
                else
                {
                    price = nights * 25 - (nights * 25 * 0.5);
                }

                if (feedBack == "positive")
                {
                    Console.WriteLine("{0:F2}", price + price * 0.25);
                }
                else
                {
                    Console.WriteLine("{0:F2}", price - price * 0.1);
                }
            }
            else if (roomType == "president apartment")
            {
                if (nights < 10)
                {
                    price = nights * 35 - (nights * 35 * 0.1);
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price = nights * 35 - (nights * 35 * 0.15);
                }
                else
                {
                    price = nights * 35 - (nights * 35 * 0.2);
                }

                if (feedBack == "positive")
                {
                    Console.WriteLine("{0:F2}", price + price * 0.25);
                }
                else
                {
                    Console.WriteLine("{0:F2}", price - price * 0.1);
                }
            }
            else if (roomType == "room for one person")
            {
                {
                    price = nights * 18;
                }
                if (feedBack == "positive")
                {
                    Console.WriteLine("{0:F2}", price + price * 0.25);
                }
                else
                {
                    Console.WriteLine("{0:F2}", price - price * 0.1);
                }
            }
        }
    }
}
