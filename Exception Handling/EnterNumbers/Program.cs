using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = ReadNumber(start, 100);
            if (arr[i] <= start)
            {
                Console.WriteLine("enter a number bigger than {0} and less than 100", start);
                i--;
                continue;
            }
            start = arr[i];
        }
    }

    public static int ReadNumber(int start, int end)
    {
        int number = 0;

        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("you entered an invalid number");
        }
        return number;
    }
}