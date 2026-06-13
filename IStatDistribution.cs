namespace CharacterCreatorOOP
{
    public interface IStatDistribution
    {
        string PlayerCharacter { get; set; }

        int Charisma { get; set; }
        int Constitution { get; set; }
        int Dexterity { get; set; }
        int Intelligence { get; set; }
        int Strength {  get; set; }
        int Wisdom { get; set; }    

    }
}

