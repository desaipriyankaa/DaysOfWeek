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

            foreach (string day in DaysOfWeeks)
            {
                Console.WriteLine(day);
            }
        }

    }
}
