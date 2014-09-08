using System;

namespace DesignPatterns.Factory
{
    public sealed class FantasyCharacterGenerator : AbstractCharacterFactory
    {
        public override Character CreateCharacter()
        {
            return new ElfCharacter();
        }

        public override Monster CreateMonster()
        {
            return new Orc();
        }
    }

    public sealed class Orc : Monster
    {
    }

    public sealed class ElfCharacter : Character
    {
        public override void Attack(Monster monster)
        {
            Console.Write("The {0} pricks the {1} with a girly dagger.", GetType().Name, monster.GetType().Name);
        }
    }
}
