﻿using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:F2}", comission);
            }

            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:F2}", comission);
            }

            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:F2}", comission);
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
