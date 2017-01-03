using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class GladiatorContext: DbContext
    {
        public DbSet<Gladiator> Gladiators { get; set; }
        public DbSet<Weapon> Weapons { get; set; } 
        public DbSet<GameResult> GameResults { get; set; } 
        public DbSet<Setting> Settings { get; set; }
    }
}
