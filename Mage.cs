namespace CharacterCreatorOOP
{
    public class Mage : Combat, IStatDistribution
    {
        public CharacterClass Identity { get; set; } = CharacterClass.Mage;

        public string PlayerCharacter { get; set; } = "Unnamed Mage";
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
    }
} 

