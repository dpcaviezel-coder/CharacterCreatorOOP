using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreatorOOP
{
    public abstract class BaseCharacter : Combat, IStatDistribution
    {
        public string PlayerCharacter { get; set; } = "Unnamed";

        public CharacterClass Identity { get; protected set; }

        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }

        public void PrintStats()
        {
            Console.WriteLine($"=== {PlayerCharacter} ({Identity}) ===");
            Console.WriteLine($"STR: {Strength}");
            Console.WriteLine($"DEX: {Dexterity}");
            Console.WriteLine($"INT: {Intelligence}");
            Console.WriteLine($"CON: {Constitution}");
            Console.WriteLine($"WIS: {Wisdom}");
            Console.WriteLine($"CHA: {Charisma}");
            Console.WriteLine();
        }
    }
}
