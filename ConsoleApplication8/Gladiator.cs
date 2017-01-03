using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Gladiator : IComparable
    {
        private List<string> nameList = new List<string> { "Spartacus", " Crixus", " Gannicus", "Oenomaus", "Castus"};
        private const int minHeight = 150;
        private const int maxHeight = 220;
        public string Name { get; set; }
        public int Height { get; set; }
        public int HitPoint { get; set; }
        public int AttackDamage { get; set; }
        public bool IsAlive
        {
            get
            {
                return (HitPoint > 0);
            }
        }
        public Gladiator(Random generator)
        {
            //var generator = new Random();
            Height = generator.Next(minHeight, maxHeight);
            int randomNameIndex = generator.Next(0, nameList.Count);
            InitializeParams();
            Name = nameList[randomNameIndex];
        }



        public Gladiator(string name, int height)
        {
            //var generator = new Random();
            Height = height;
            InitializeParams();
            Name = name;
        }

        public int CompareTo(object obj)
        {
            Gladiator gladiatorCompareTo= obj as Gladiator;
            if (gladiatorCompareTo.Height < Height)
            {
                return 1;
            }
            if (gladiatorCompareTo.Height > Height)
            {
                return -1;
            }

            return 0;
        }
        private void InitializeParams()
        {
            //50 is hp modifier
            HitPoint = Height + 50;
            AttackDamage = (Height + HitPoint) / 10;
        }

        public void Salutation()
        {
            if (IsAlive)
            {
                Console.WriteLine("Argghh!I'm " + Name + " My height is " + Height + " I have " + HitPoint +
                                  " Now, i kick your ass for " + AttackDamage + " HP ");
            }
            else
            {
                //todo: add logic
                Console.WriteLine("I AM DNIWE EBANOE AND DIED!!! ");
            }
        }

        public void Attack(Gladiator gladiator)
        {
            gladiator.HitPoint = gladiator.HitPoint - AttackDamage;
            Console.WriteLine("{0} hits {1} for {2} HP, {1} has {3} HP", Name, gladiator.Name, AttackDamage, gladiator.HitPoint);
        }


    }
}
