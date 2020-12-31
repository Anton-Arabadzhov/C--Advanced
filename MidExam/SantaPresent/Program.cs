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

            Dictionary<int, string> presentsMagicLevel = new Dictionary<int, string>
            {
                { 150, "Doll"},
                { 250, "Wooden train"},
                { 300, "Teddy bear"},
                { 400, "Bicycle"}
            };
            Dictionary<string, int> presentMade = new Dictionary<string, int>();

            while (matirialForCrafting.Count > 0 && magicLevelValue.Count > 0)
            {
                int magicLevel = matirialForCrafting.Peek() * magicLevelValue.Peek();

                if (presentsMagicLevel.ContainsKey(magicLevel))
                {
                    if (!presentMade.ContainsKey(presentsMagicLevel[magicLevel]))
                    {
                        presentMade.Add(presentsMagicLevel[magicLevel], 0);
                    }
                    presentMade[presentsMagicLevel[magicLevel]]++;

                    matirialForCrafting.Pop();
                    magicLevelValue.Dequeue();
                }
                else
                {
                    if (magicLevel <0)
                    {
                        int sum = matirialForCrafting.Peek() + magicLevelValue.Peek();
                        matirialForCrafting.Pop();
                        magicLevelValue.Dequeue();
                        matirialForCrafting.Push(sum);
                    }
                    else if (magicLevel > 0)
                    {
                        int material = matirialForCrafting.Peek() + 15;
                        magicLevelValue.Dequeue();
                        matirialForCrafting.Pop();
                        matirialForCrafting.Push(material);
                    }
                    else if (magicLevel == 0)
                    {
                        if (matirialForCrafting.Peek() == 0)
                        {
                            matirialForCrafting.Pop();
                        }
                        if (magicLevelValue.Peek() == 0)
                        {
                            magicLevelValue.Dequeue();
                        }
                    }
                }
            }
            if ((presentMade.ContainsKey("Doll") && presentMade.ContainsKey("Wooden train"))||
                 (presentMade.ContainsKey("Teddy bear") && presentMade.ContainsKey("Bicycle")))
            {
                Console.WriteLine($"The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (matirialForCrafting.Count > 0)
            {
                Console.WriteLine("Materials left: " + string.Join(", ", matirialForCrafting));
            }
            if (magicLevelValue.Count > 0)
            {
                Console.WriteLine("Magic left: " + string.Join(", ", magicLevelValue));
            }
            foreach (var present in presentMade.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{present.Key}: {present.Value}");
            }
        }
    }
}
