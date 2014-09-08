using System;

namespace DesignPatterns.Factory
{
    public sealed class SciFiCharacterGenerator : AbstractCharacterFactory
    {
        public override Character CreateCharacter()
        {
            return new SpaceMarine();
        }

        public override Monster CreateMonster()
        {
            return new WarriorBug();
        }
    }

    public sealed class WarriorBug : Monster
    {}

    public sealed class SpaceMarine : Character
    {
        public override void Attack(Monster monster)
        {
            Console.WriteLine("The {0} attacks the {1}", GetType().Name, monster.GetType().Name);
        }
    }
}
