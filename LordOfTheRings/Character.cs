namespace LordOfTheRings
{
    public sealed class Character
    {
        private Character(Name name, string race, Weapon weapon)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
        }

        public Name Name { get; set; }
        public string Race { get; set; }
        public Weapon Weapon { get; set; }
        public string Region { get; set; } = "Shire";


        public static Character Create(string name, string race, Weapon weapon)
        {
            
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Character must have a name.");
            }

            if (string.IsNullOrWhiteSpace(race))
            {
                throw new ArgumentException("Character must have a race.");
            }

            if (weapon == null)
            {
                throw new ArgumentException("Character must have a weapon.");
            }

            if (string.IsNullOrWhiteSpace(weapon.Name))
            {
                throw new ArgumentException("A weapon must have a name.");
            }
            if (weapon.Damage <= 0)
            {
                throw new ArgumentException("A weapon must have a damage level.");
            }

            return new Character(LordOfTheRings.Name.Create(name), race, weapon);
        }
        
        
    }
}