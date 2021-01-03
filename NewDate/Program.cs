using System;

namespace NewDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number");
            double hours = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now;
            DateTime date1 = date.AddHours(hours);

            Console.WriteLine("It will be {0} in {1} hours", date1, hours);
        }
    }
}
