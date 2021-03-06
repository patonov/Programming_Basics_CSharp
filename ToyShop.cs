﻿using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int teddyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            int totalToyCount = puzzleCount + dollsCount + teddyBearsCount + minionsCount + trucksCount;
            double totalPrice = puzzleCount * 2.60 + dollsCount * 3 + teddyBearsCount * 4.10 + minionsCount * 8.20 + trucksCount * 2;

            if (totalToyCount >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }

            totalPrice = totalPrice * 0.9;

            if (totalPrice >= vacationPrice)
            {
                double difference = totalPrice - vacationPrice;
                Console.WriteLine("Yes! {0:F2} lv left.", difference);
            }
            else
            {
                double difference = vacationPrice - totalPrice;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", difference);
            }
        }
    }
}
