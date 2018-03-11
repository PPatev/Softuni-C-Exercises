using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Objects_and_Classes___Exercises
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dateFirst = DateTime.ParseExact(
              date, "dd-MM-yyyy",
              CultureInfo.InvariantCulture);
            date = Console.ReadLine();
            DateTime dateSecond = DateTime.ParseExact(
              date, "dd-MM-yyyy",
              CultureInfo.InvariantCulture);
            int count = 0;
            var holidays = new HashSet<string>();
            holidays.Add("1-1");
            holidays.Add("3-3");
            holidays.Add("1-5");
            holidays.Add("6-5");
            holidays.Add("24-5");
            holidays.Add("6-9");
            holidays.Add("22-9");
            holidays.Add("1-11");
            holidays.Add("24-12");
            holidays.Add("25-12");
            holidays.Add("26-12");

            while (true)
            {
                if (!dateFirst.DayOfWeek.Equals(DayOfWeek.Saturday) 
                    && !dateFirst.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    var day = dateFirst.Day;
                    var month = dateFirst.Month;
                    var dayMonth = $"{day}-{month}";
                    if (!holidays.Contains(dayMonth))
                    {
                        count++;
                    }
                }

                if (dateFirst.Equals(dateSecond))
                {
                    break;
                }

                dateFirst = dateFirst.AddDays(1);
            }

            Console.WriteLine(count);
        }
    }
}
