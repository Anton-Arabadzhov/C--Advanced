using System;

namespace CostumTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split();
            string fullname = $"{firstTupleData[0]} {firstTupleData[1]}";
            MyTuple<string, string> firsttuple = new MyTuple<string, string>(fullname, firstTupleData[2]);
            string[] SecondTupleData = Console.ReadLine().Split();
            MyTuple<string, int> sectuple = new MyTuple<string, int>(SecondTupleData[0], int.Parse(SecondTupleData[1]));
            string[] ThirdTupleData = Console.ReadLine().Split();
            MyTuple<int, double> thurttuple = new MyTuple<int, double>(int.Parse(ThirdTupleData[0]), double.Parse(ThirdTupleData[1]));

            Console.WriteLine(firsttuple);
            Console.WriteLine(sectuple);
            Console.WriteLine(thurttuple);
        }
    }
}
