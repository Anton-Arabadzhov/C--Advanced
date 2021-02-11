using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BoxOfT<int> box = new BoxOfT<int>();

            box.Add(4);
            box.Add(5);
            box.Add(6);

            Console.WriteLine(box.Count); // return 3
            Console.WriteLine(box.Remove());// remove First Element
            Console.WriteLine(box.Remove()); // remove first element
            Console.WriteLine(box.Count);// return 1

        }
    }
}
