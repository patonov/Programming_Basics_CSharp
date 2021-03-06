﻿using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int solvable = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double nylonCosts = (nylon * 1.50) + (2 * 1.50);
            double paintCosts = (paint * 14.50) + (paint * 14.50) * 0.1;
            double solvableCosts = solvable * 5.00;

            double totalCostsForMaterials = nylonCosts + paintCosts + solvableCosts + 0.40;
            double workCosts = workHours * (totalCostsForMaterials * 0.3);

            double totalCosts = totalCostsForMaterials + workCosts;

            Console.WriteLine("Total expenses: {0:F2} lv.", totalCosts);
        }
    }
}
