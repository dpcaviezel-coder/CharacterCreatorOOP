namespace CharacterCreatorOOP
{
    public class Archer : Combat, IStatDistribution
    {
        public CharacterClass Identity { get; set; } = CharacterClass.Archer;

        public string PlayerCharacter { get; set; } = "Unnamed Archer";

        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
    }
} 

