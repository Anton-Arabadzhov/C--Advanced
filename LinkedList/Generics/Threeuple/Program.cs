using System;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string city = default;
            string name = input1[0] + " " + input1[1];
            
            if (input1.Length == 4)
            {
                
                city = input1[3];
                
            }
            else
            {
               city = input1[3] + " " + input1[4];
            }

            Threeuple<string, string, string> firstLine = new Threeuple<string, string, string>(name, input1[2], city);

            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool isDrunk = input2[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> secodLine = new Threeuple<string, int, bool>(input2[0], int.Parse(input2[1]), isDrunk);

            string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            Threeuple<string, double, string> thirtLine = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);



            Console.WriteLine(firstLine);
            Console.WriteLine(secodLine);
            Console.WriteLine(thirtLine);



        }
    }
}
