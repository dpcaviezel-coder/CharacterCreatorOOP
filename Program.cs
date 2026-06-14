using CharacterCreatorOOP;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IStatDistribution> CharacterSheet = new List<IStatDistribution>()
        {

        new Assassin() { PlayerCharacter = "Assassin Name" },
        new Archer() { PlayerCharacter = "Archer Name" },
        new Bard() { PlayerCharacter = "Bard Name" },
        new Mage() { PlayerCharacter = "Mage Name" },
        new Paladin() { PlayerCharacter = "Paladin Name" },
        new Priest() { PlayerCharacter = "Priest Name" },
        new Warlock() { PlayerCharacter = "Warlock Name" },
        new Warrior() { PlayerCharacter = "Warrior Name" }

        };

        foreach (var character in CharacterSheet)
        {
            Console.WriteLine($"Character: {character.PlayerCharacter}");
            Console.WriteLine($"STR: {character.Strength}");
            Console.WriteLine($"DEX: {character.Dexterity}");
            Console.WriteLine($"INT: {character.Intelligence}");
            Console.WriteLine($"CON: {character.Constitution}");
            Console.WriteLine($"WIS: {character.Wisdom}");
            Console.WriteLine($"CHA: {character.Charisma}");
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
