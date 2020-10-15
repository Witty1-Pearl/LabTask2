using System;

namespace DateTest
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public void DisplayDay()
        {
            Console.WriteLine("{0:00}/{1:00}/{2:00}", Month, Day, Year);
        }
    }
}