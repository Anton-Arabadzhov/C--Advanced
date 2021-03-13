using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var temasByName = new Dictionary<string, Team>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var parts = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string comand = parts[0];
                string team = parts[1];

                try
                {

                    if (comand == "Team")
                    {
                        Team newteam = new Team(team);
                        temasByName.Add(team, newteam);

                    }
                    else if (comand == "Add")
                    {
                        if (!temasByName.ContainsKey(team))
                        {
                            Console.WriteLine($"Team {team} does not exist.");
                            continue;
                        }
                        else
                        {
                            var newteam = temasByName[team];
                            Player newplayer = new Player(
                                parts[2],
                                int.Parse(parts[3]),
                                int.Parse(parts[4]),
                                int.Parse(parts[5]),
                                int.Parse(parts[6]),
                                int.Parse(parts[7]));
                            newteam.AddPlayer(newplayer);
                        }
                    }
                    else if (comand == "Remove")
                    {
                        string player = parts[2];
                        var newteam = temasByName[team];
                        newteam.RemovePlayer(player);
                    }
                    else if (comand == "Rating")
                    {
                        if (!temasByName.ContainsKey(team))
                        {
                            Console.WriteLine($"Team {team} does not exist.");
                            continue;
                        }

                        var newteam = temasByName[team];
                        Console.WriteLine($"{team} - {newteam.AverageRating}");
                    }

                }
                catch (Exception ex)
                when(ex is ArgumentException || ex is InvalidOperationException)
                {

                    Console.WriteLine(ex.Message);
                }

            }



        }
    }
}
