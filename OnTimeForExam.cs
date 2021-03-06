﻿using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = double.Parse(Console.ReadLine());
            var examMins = double.Parse(Console.ReadLine());
            var arrivalHour = double.Parse(Console.ReadLine());
            var arrivalMins = double.Parse(Console.ReadLine());

            var examTime = (examHour * 60) + examMins;
            var arrivalTime = (arrivalHour * 60) + arrivalMins;

            if (arrivalTime > examTime)
            {
                var timeLate = arrivalTime - examTime;

                if (timeLate >= 60)
                {
                    var hoursLate = timeLate / 60;
                    var minsLate = timeLate % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:00} hours after the start", Math.Floor(hoursLate), minsLate);
                }
                else if (timeLate < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0:00} minutes after the start", timeLate);
                }
            }
            else if (arrivalTime < examTime)
            {
                var timeEarly = examTime - arrivalTime;

                if ((timeEarly > 30) && (timeEarly < 60))
                {
                    var hoursEarly = timeEarly / 60;
                    var minsEarly = timeEarly % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0:00} minutes before the start", minsEarly);
                }
                else if (timeEarly > 30 && timeEarly >= 60)
                {
                    var hoursEarly = timeEarly / 60;
                    var minsEarly = timeEarly % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Floor(hoursEarly), minsEarly);
                }
                else if (timeEarly <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", timeEarly);
                }
            }
            else if (arrivalTime == examTime)
            {
                Console.WriteLine("On time");
            }
        }
    
    }
}
