using System;
using System.Collections.Generic;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string outputFilePath = Path.Combine("..", "..", "..", "output.txt");
            string[] lines = File.ReadAllLines("text.txt");
            List<char> punctuations = new List<char>() { '-', ',', '.', '!', '?', '\''};
            List<string> newLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int lettersCount = 0;
                int punctoationCount = 0;
                foreach (char ch in line)
                {
                    

                    if (char.IsLetter(ch))
                    {
                        lettersCount++;
                    }
                    else if (punctuations.Contains(ch))
                    {
                        punctoationCount++;
                    }
                }

                string neLine = $"Line {i + 1}: {line} ({lettersCount}/{punctoationCount})";

                newLines.Add(neLine);

                
            }
            Console.WriteLine(string.Join(Environment.NewLine, newLines));
            File.WriteAllLines(outputFilePath, newLines);
        }
    }
}
