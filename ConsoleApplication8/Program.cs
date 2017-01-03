using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{ 
    class Program
    {
        static void Main(string[] args)
        {
            GladiatorFight gameFight = new GladiatorFight();
            gameFight.Play(2);
            Console.ReadLine();
        }
    }
}

