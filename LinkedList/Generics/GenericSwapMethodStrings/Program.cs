using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> newbox = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                newbox.Add(box);
                
            }

            string command = Console.ReadLine();
            string[] swapIndexes = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int firstIn = int.Parse(swapIndexes[0]);
            int secondIn = int.Parse(swapIndexes[1]);
            SwapIndexes(newbox, firstIn, secondIn);
            foreach (var box in newbox)
            {
                Console.WriteLine(box.ToString());
            }
        }

        
        private static void SwapIndexes<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
