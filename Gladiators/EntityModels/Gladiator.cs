using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators.EntityModels
{
    public class Gladiator: BaseEntity
    {
        [ForeignKey("Weapon")]
        public int Weapon_Id { get; set; }
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int Power { get; set; }
        public virtual Weapon Weapon { get; set; }

    }
}
