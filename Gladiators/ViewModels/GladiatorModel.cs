using Gladiators.EntityModels;

namespace Gladiators.ViewModels
{
    public class GladiatorModel
    {
        public GladiatorModel(Gladiator gladFromDb)
        {
            Hitpoints = gladFromDb.Hitpoints;
            Name = gladFromDb.Name;
            Power = gladFromDb.Power;
            Weapon = new WeaponModel()
            {
                Damage = gladFromDb.Weapon.Damage,
                Name = gladFromDb.Weapon.Name
            };
        }
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int Power { get; set; }
        public WeaponModel Weapon { get; set; }

    }
}
