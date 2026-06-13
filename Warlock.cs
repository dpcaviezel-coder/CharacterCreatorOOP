namespace CharacterCreatorOOP
{
    public class Warlock : Combat, IStatDistribution
    {
        public CharacterClass Identity { get; set; } = CharacterClass.Warlock;

        public string PlayerCharacter { get; set; } = "Unnamed Warlock";
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
    }
} 

