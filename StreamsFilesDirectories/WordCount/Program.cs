using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string expectedResultPath = Path.Combine("expectedResult.txt");
           string[] words = File.ReadAllLines("words.txt");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();


            foreach (var word in words)
            {
                wordsCount.Add(word, 0);
            }

            string text = File.ReadAllText("text.txt").ToLower();
            string[] textWord = text.Split(
                new string[] { " ", ".", ",", "!", "?", "-", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in textWord)
            {
                if (wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount[word]++;
                }
            }

            Dictionary<string, int> sortedDict = wordsCount
                .OrderByDescending(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            List<string> outputLines = sortedDict
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToList();

            File.WriteAllLines("expectedResult.txt", outputLines);
        }
    }
}
