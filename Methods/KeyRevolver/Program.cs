using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bullerPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);

            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int inteligenceValue = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currentBarretSize = gunBarrelSize;

            while (bullets.Any() && locks.Any())
            {
                bulletsCount++;
                currentBarretSize--;
                int currentbullet = bullets.Pop();
                int currentLock = locks.Peek();

              

                if (currentbullet <= currentLock)
                {
                    Console.WriteLine($"Bang!");
                    locks.Dequeue();
                   
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentBarretSize == 0 && bullets.Any())
                {
                    currentBarretSize = gunBarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }
            if (!locks.Any())
            {
                int moneyEarned = inteligenceValue - (bulletsCount * bullerPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }


        }
    }
}
