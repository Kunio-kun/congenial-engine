﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiators.EntityModels;
using Gladiators.ViewModels;

namespace Gladiators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            MainMenu.RunMenu();
            Console.WriteLine("bye");
            Console.ReadLine();

        }
    }
}
