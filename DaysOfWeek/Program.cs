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
                                    "Wednesday",
                                    "Thursday",
                                    "Friday",
                                    "Satursday",
                                    "Sunday"
                                  };

            Console.WriteLine("Which day you want to display?... Enter number (e.g - Monday = 1) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = DaysOfWeeks[iDay];
            Console.WriteLine($"That day is > {chosenDay}");
        }

    }
}
