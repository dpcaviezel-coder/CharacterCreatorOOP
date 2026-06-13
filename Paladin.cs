namespace CharacterCreatorOOP
{
    public class Paladin : Combat, IStatDistribution
    {
        public CharacterClass Identity { get; set; } = CharacterClass.Paladin;

        public string PlayerCharacter { get; set; } = "Unnamed Paladin";
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
    }
} 

