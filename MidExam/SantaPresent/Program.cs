using System;
using System.Collections.Generic;
using System.Linq;

namespace SantaPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> matirialForCrafting = new Stack<int>(input1);
            Queue<int> magicLevelValue = new Queue<int>(input2);

            while (matirialForCrafting.Count > 0 && magicLevelValue.Count > 0)
            {

            }
        }
    }
}
