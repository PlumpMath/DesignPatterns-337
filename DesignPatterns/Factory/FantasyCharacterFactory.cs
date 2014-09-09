using System;

namespace DesignPatterns.Factory
{
    public sealed class FantasyCharacterFactory : AbstractCharacterFactory
    {
        public override Character CreateCharacter()
        {
            return new Elf();
        }

        public override Monster CreateMonster()
        {
            return new Orc();
        }
    }

    public sealed class Orc : Monster
    {
    }

    public sealed class Elf : Character
    {
        public override void Attack(Monster monster)
        {
            Console.Write("The {0} attacks the {1}.", GetType().Name, monster.GetType().Name);
        }
    }
}
