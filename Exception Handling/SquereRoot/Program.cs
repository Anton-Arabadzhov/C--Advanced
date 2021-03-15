using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("enter an integer number");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int squareRoot = (int)Math.Sqrt(num);
                Console.WriteLine("the square root of {0} is {1}", num, squareRoot);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number should not be negative");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}