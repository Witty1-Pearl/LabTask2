using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(15, 10, 2020);
            date.DisplayDay();

            Console.ReadLine();
        }
    }
}
