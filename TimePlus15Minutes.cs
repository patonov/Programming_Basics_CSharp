﻿using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingHours = int.Parse(Console.ReadLine());
            int startingMinutes = int.Parse(Console.ReadLine());

            int totalMinutes = startingHours * 60 + startingMinutes;

            int totalMinutesPlus = totalMinutes + 15;

            int currentHours = totalMinutesPlus / 60;
            int currentMinutes = totalMinutesPlus % 60;

            if (currentHours == 24)
            {
                currentHours -= 24;
            }

            if (currentMinutes < 10)
            {
                Console.WriteLine("{0}:0{1}", currentHours, currentMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", currentHours, currentMinutes);
            }
        }
    }
}
