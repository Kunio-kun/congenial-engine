using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators.EntityModels
{
    public class Weapon: BaseEntity
    {
        public string Name { get; set; }
        public int Damage { get; set; }
    }
}
