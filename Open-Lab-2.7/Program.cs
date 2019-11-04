using System;

namespace Open_Lab_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Christmas christmas = new Christmas();
            Console.WriteLine(christmas.IsTimeForMilkAndCookies(12, 24));
        }
    }
}