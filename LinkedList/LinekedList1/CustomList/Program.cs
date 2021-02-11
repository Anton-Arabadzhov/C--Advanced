using System;

namespace CustomStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            CostumList list = new CostumList();
            list.Add(5);
            list.Add(15);
            list.Add(25);
            list.Add(35);
            list.Add(45);


            list.ForEach((item) =>
            {
                Console.WriteLine(item);
            });
        }
    }
}
