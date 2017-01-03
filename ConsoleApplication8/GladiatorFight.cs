using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class GladiatorFight
    {
        public void Play(int numberOfPirates)
        {
            List<Gladiator> gladiatotList = new List<Gladiator>();
            //if (numberOfPirates % 2 != 0)
            //{
            //    numberOfPirates++;
            //    Console.WriteLine("Pirates number is odd! Going to Tortuga to get one more pirate!");
            //}
            for (int i = 0; i < numberOfPirates; i++)
            {
                gladiatotList.Add(new Gladiator(new Random(i)));
            }
            gladiatotList.Sort();
            foreach (var pirate in gladiatotList)
            {
                pirate.Salutation();
            }
            List<Gladiator> blueTeam = new List<Gladiator>();
            List<Gladiator> redTeam = new List<Gladiator>();
            for (int i = 0; i < gladiatotList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    blueTeam.Add(gladiatotList[i]);
                }
                else
                {
                    redTeam.Add(gladiatotList[i]);
                }
            }
            Console.WriteLine("Blue team salutes");
            SaluteAll(blueTeam);
            Console.WriteLine("Red team salutes");
            SaluteAll(redTeam);

            var teamCount = gladiatotList.Count / 2;
            while (isAnyoneAlive(blueTeam) && isAnyoneAlive(redTeam))
            {
                for (int i = 0; i < teamCount; i++)
                {
                    var random = new Random();
                    Thread.Sleep(100);
                    if (blueTeam[i].IsAlive)
                    {
                        blueTeam[i].Attack(redTeam[random.Next(teamCount)]);
                    }
                    if (redTeam[i].IsAlive)
                    {
                        redTeam[i].Attack(blueTeam[random.Next(teamCount)]);
                    }
                }
            }
            if (isAnyoneAlive(redTeam))
            {
                Console.WriteLine("Red team is the Winner");
                SaluteAll(redTeam);
            }
            else
            {
                Console.WriteLine("Blue team is the Winner");
                SaluteAll(blueTeam);
            }


        }

        private static void SaluteAll(List<Gladiator> blueTeam)
        {
            foreach (var pirate in blueTeam)
            {
                pirate.Salutation();
            }
        }

        private bool isAnyoneAlive(List<Gladiator> team)
        {
            int alive = 0;
            foreach (var pirate in team)
            {
                if (pirate.IsAlive)
                {
                    alive++;
                }

            }
            return alive > 0;
        }
    }
}
