using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiersbyID = new Dictionary<string, ISoldier>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }
                var parts = line.Split();

                string type = parts[0];
                string id = parts[1];
                string firstName = parts[2];
                string lastName = parts[3];


                if (type == nameof(Private))
                {
                    decimal salary = decimal.Parse(parts[4]);
                    soldiersbyID[id] = new Private(id, firstName, lastName, salary);
                }
                else if (type == nameof(LieutenantGeneral))
                {
                    decimal salary = decimal.Parse(parts[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < parts.Length; i++)
                    {
                        string privateId = parts[i];

                        if (!soldiersbyID.ContainsKey(privateId))
                        {
                            continue;
                        }

                        lieutenantGeneral.AddPrivate((IPrivate)soldiersbyID[privateId]);
                    }

                    soldiersbyID[id] = lieutenantGeneral;

                }
                else if (type == nameof(Engineer))
                {
                    decimal salary = decimal.Parse(parts[4]);

                    bool isCorpsValid = Enum.TryParse(parts[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }

                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        string part = parts[i];
                        int hourseWorker = int.Parse(parts[i + 1]);

                        IRepair repair = new Repair(part, hourseWorker);
                        engineer.AddRepair(repair);
                    }
                    soldiersbyID[id] = engineer;
                }
                else if (type == nameof(Commando))
                {
                    decimal salary = decimal.Parse(parts[4]);
                    bool isCorpsValid = Enum.TryParse(parts[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    ICommando comando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        string codeName = parts[i];
                        string states = parts[i + 1];
                        bool osMissionStateValid = Enum.TryParse(states, out MissionState Mstate);

                        if (!osMissionStateValid)
                        {
                            continue;
                        }

                        IMission mission = new Mission(codeName, Mstate);

                        comando.AddMission(mission);


                    }
                    soldiersbyID[id] = comando;

                }
                else if (type == nameof(Spy))
                {
                    int codeNumber = int.Parse(parts[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiersbyID[id] = spy;
                }

            }

            foreach (var soldier in soldiersbyID.Values)
            {
                Console.WriteLine(soldier);
            }

        }
    }
}
