using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiators.Context;
using Gladiators.EntityModels;

namespace Gladiators.Editors
{
    public class WeaponEditor:IInstanceEditor
    {
        public void RunEditor()
        {
            while (true)
            {
                var answer=BaseMenu.RunBaseMenu(BaseMenu.BaseEditorOptions);
                if (answer == "1")
                {
                    var weapon = new Weapon();
                    Console.WriteLine(" Please, enter weapon's name");
                    weapon.Name = Console.ReadLine();
                    Console.WriteLine(" Please, enter weapon's damage");
                    weapon.Damage = Convert.ToInt32(Console.ReadLine()); //todo handle wrong input
                    using (var context = new GameContext())
                    {
                        context.Weapons.Add(weapon);
                        context.SaveChanges();
                    }
                    Console.WriteLine("Weapon saved ");
                }
                else if (answer == "2")
                {
                    using (var context = new GameContext())
                    {
                        var weaponsList = context.Weapons.ToList();
                        foreach (var weapon in weaponsList)
                        {
                            Console.WriteLine($"{weapon.Id} - {weapon.Name} ({weapon.Damage})");
                        }
                        Console.WriteLine("What do you want to delete?");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        var weaponToDelete = context.Weapons.Find(idToDelete);
                        if (weaponToDelete != null)
                        {
                            context.Weapons.Remove(weaponToDelete);
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Can't find weapon");
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
