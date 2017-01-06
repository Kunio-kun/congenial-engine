using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiators.Context;
using Gladiators.EntityModels;
using Gladiators.Helpers;

namespace Gladiators.Editors
{
    public class GladiatorEditor : IInstanceEditor
    {
        public void RunEditor()
        {


            while (true)
            {
                var answer = BaseMenu.RunBaseMenu(BaseMenu.BaseEditorOptions);
                if (answer == "1")
                {
                    var gladiator = new Gladiator();
                    Console.WriteLine(" Please, enter gladiator's name");
                    gladiator.Name = Console.ReadLine();
                    Console.WriteLine(" Please, enter gladiator's HP");
                    gladiator.Hitpoints = ConsoleHelpers.ReadIntInput(); 
                    Console.WriteLine(" Please, enter gladiator's name");
                    gladiator.Power = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Please, choose gladiator's weapon");

                    using (var context = new GameContext())
                    {


                        var weaponsList = context.Weapons.ToList();
                        foreach (var weapon in weaponsList)
                        {
                            Console.WriteLine($"{weapon.Id} - {weapon.Name} ({weapon.Damage})");
                        }
                        Console.WriteLine("What do you want to choose?");
                        while (gladiator.Weapon == null)
                        {
                            int idToChoose = Convert.ToInt32(Console.ReadLine());
                            var weaponToChoose = context.Weapons.Find(idToChoose);
                            if (weaponToChoose != null)
                            {
                                gladiator.Weapon = weaponToChoose;
                            }
                            else
                            {
                                Console.WriteLine("Can't find weapon");
                            }
                        }

                        context.Gladiators.Add(gladiator);
                        context.SaveChanges();
                    }
                    Console.WriteLine("Gladiator saved ");
                }
                else if (answer == "2")
                {
                    using (var context = new GameContext())
                    {
                        var gladiatorsList = context.Gladiators.ToList();
                        foreach (var gladiator in gladiatorsList)
                        {
                            Console.WriteLine($"{gladiator.Id} - {gladiator.Name}");
                        }
                        Console.WriteLine("Which do you want to delete?");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        var gladiatorToDelete = context.Gladiators.Find(idToDelete);
                        if (gladiatorToDelete != null)
                        {
                            context.Gladiators.Remove(gladiatorToDelete);
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Can't find gladiator");
                        }

                    }
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
