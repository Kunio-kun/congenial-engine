using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators.EntityModels
{
    public class Gladiator: BaseEntity
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int Power { get; set; }
        public Weapon Weapon { get; set; }

    }
}
