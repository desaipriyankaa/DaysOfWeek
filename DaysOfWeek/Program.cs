using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DaysOfWeeks = {
                                    "Monday",
                                    "Tuesday",
                                    "Wenesday",
                                    "Thursday",
                                    "Friday",
                                    "Satursday",
                                    "Sunday"
                                  };

            Console.WriteLine("Before : ");
            foreach (string day in DaysOfWeeks)
                Console.WriteLine(day);

            DaysOfWeeks[2] = "wednesday";

            Console.WriteLine("\nAfter : ");
            foreach (string day in DaysOfWeeks)
                Console.WriteLine(day);
        }

    }
}
