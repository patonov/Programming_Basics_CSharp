﻿using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tablesCount = double.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double tableClothPriceUSD = tablesCount * (tableLenght + 2 * 0.30) * (tableWidth + 2 * 0.30) * 7;
            double tableTopperPriceUSD = tablesCount * (tableLenght * 0.5) * (tableLenght * 0.5) * 9;

            double priceUSD = tableClothPriceUSD + tableTopperPriceUSD;
            double priceBGN = priceUSD * 1.85;

            Console.Write("{0:F2}", priceUSD);
            Console.WriteLine(" USD");
            Console.Write("{0:F2}", priceBGN);
            Console.WriteLine(" BGN");
        }
    }
}
