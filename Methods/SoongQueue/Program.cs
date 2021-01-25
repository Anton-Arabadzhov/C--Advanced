using System;
using System.Collections.Generic;
using System.Text;

namespace SoongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(input);
            
            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                string[] comrg = command.Split();
                string action = comrg[0];

                
                if (action == "Play")
                {
                    songs.Dequeue();
                }
                else if (action == "Add")
                {
                    StringBuilder sb = new StringBuilder();
                    string song = "";
                    if (comrg.Length > 2)
                    {
                        for (int i = 1; i < comrg.Length; i++)
                        {
                            sb.Append(comrg[i]+ ' ');
                        }
                       song = sb.ToString().Trim();
                    }
                    else
                    {
                        song = comrg[1];
                    }

                    
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }


                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
