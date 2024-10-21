namespace LordOfTheRings
{
    public sealed class Character
    {
        private Character(Name name, Race race, Weapon weapon)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
        }

        public Name Name { get; set; }
        public Race Race { get; set; }
        public Weapon Weapon { get; set; }
        public string Region { get; set; } = "Shire";


        public static Character Create(string name, string race, Weapon weapon)
        {
            return new Character(Name.Create(name), Race.Create(race), weapon);
        }


        public void MoveToRegion(Region region)
        {
            if (this.Region == Region.Mordor && region != Region.Mordor)
            {
                throw new InvalidOperationException(
                    $"Cannot move {this.Name} from Mordor to {region}. Reason: There is no coming back from Mordor.");
            }

            this.Region = region;
        }
        
        
    }
}