using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gladiators.EntityModels;

namespace Gladiators.Context
{
    public class GameContext : DbContext
    {
        public DbSet<Gladiator> Gladiators { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
