using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiators.Editors;

namespace Gladiators
{
    public static class MainMenu
    {
        public static void RunMenu()
        {
            while (true)
            {
                var options = new List<string>();
                options.Add("Start game");
                options.Add("Run Editor");
                options.Add("Exit");
                string answer = BaseMenu.RunBaseMenu(options);
                if (answer == "1")
                {
                    //todo run game menu
                }
                else if (answer == "2")
                {
                    EditorMenu();
                }
                else if (answer == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter correct answer");
                }
            }
        }

        public static void EditorMenu()
        {
            while (true)
            {
                var options=new List<string>();
                options.Add("Gladiator's Editor");
                options.Add("Weapon's Editor");
                options.Add("Exit");
                string answer = BaseMenu.RunBaseMenu(options);
                if (answer == "1")
                {
                    var editor = new GladiatorEditor();
                    editor.RunEditor();
                }
                else if (answer == "2")
                {
                    var editor=new WeaponEditor();
                    editor.RunEditor();
                }
                else if (answer == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter correct answer");
                }
            }
        }
    }
}
