using System;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new String('|', currHealth)}{new String('.', maxHealth - currHealth)}|");
            Console.WriteLine($"Energy: |{new String('|', currEnergy)}{new String('.', maxEnergy - currEnergy)}|");
        }
    }
}
