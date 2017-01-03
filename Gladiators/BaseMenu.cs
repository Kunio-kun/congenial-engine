using System;
using System.Collections.Generic;

namespace Gladiators
{
    public static class BaseMenu
    {
        public static string RunBaseMenu(List<string> menuOptions)
        {
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine((i+1)+" - " + menuOptions[i]);
            }
            return Console.ReadLine().Trim();

            //todo move to int and handle wrong answers
            //menuOptions.Count
        }

        /// <summary>
        /// 1 - Create instance
        /// 2 - Delete instance
        /// 3 - Exit
        /// </summary>
        public static List<string> BaseEditorOptions
        {
            get
            {
                var options=new List<string>();
                options.Add("Create instance");
                options.Add("Delete instance");
                options.Add("Exit");
                return options;
            }
        }
    }
}
