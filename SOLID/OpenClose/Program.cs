using OpenClose.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What strategy do you want?");

            var strategyName = Console.ReadLine();


            var strategy = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IsortingStrategy).IsAssignableFrom(t)
                && typeof(IsortingStrategy) != t)
                .First(T =>T.Name.StartsWith(strategyName));

            IsortingStrategy sortingstrategy = (IsortingStrategy)Activator.CreateInstance(strategy);  


            //if (strategyName == "Selection")
            //{
            //    sortingstrategy = new SelectionSort();
            //}
            //else if (strategyName == "Quick")
            //{
            //    sortingstrategy = new QuickSort();
            //}
            //else if (strategyName == "Bubble")
            //{
            //    sortingstrategy = new BubbleSort();
            //}
            //else if (strategyName == "Merge")
            //{
            //    sortingstrategy = new MurgeSort();
            //}

            Sorter sorter = new Sorter(sortingstrategy);

            sorter.Sort(new List<int>());
        }
    }
}
