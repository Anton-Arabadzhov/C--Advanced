using System;
using System.Collections.Generic;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            Smartphone smart = new Smartphone();
            StationaryPhone statu = new StationaryPhone();


            foreach (var num in number)
            {
                try
                {
                    string result = num.Length == 10 ? smart.Call(num) : statu.Call(num);

                    Console.WriteLine(result);

                }

                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var url in urls)
            {
                try
                {
                    var result = smart.Browzing(url);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}