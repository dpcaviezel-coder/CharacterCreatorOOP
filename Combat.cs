using System;

namespace CharacterCreatorOOP
{
    public class Combat
    {
        public int NumberOfEnemies { get; set; }

        public int RollInitiative { get; set; }

        public virtual void StartCombat()
        {
            Console.WriteLine("Initiative roll determines the attack order.");
            Console.WriteLine("Choose what action to preform");
        }

        public virtual void EndCombat()
        {
            Console.WriteLine("Battle concluded.");
            Console.WriteLine("Loot dropped.");
            Console.WriteLine("Experience gained.");
        }
    }
}


