using System;

namespace Fixing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = new string[5];
            weekdays[0] = "Sunday";
            weekdays[1] = "Monday";
            weekdays[2] = "Thuesday";
            weekdays[3] = "Wednesday";
            weekdays[4] = "Thursday";
            try
            {
            for (int i = 0; i <= weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i].ToString());
            }
            Console.ReadLine();

            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
