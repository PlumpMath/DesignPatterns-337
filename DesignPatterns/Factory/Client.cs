namespace DesignPatterns.Factory
{
    public sealed class Client
    {
        private readonly Character _character;
        private readonly Monster _monster;

        public Client( AbstractCharacterFactory factory )
        {
            _character = factory.CreateCharacter();
            _monster = factory.CreateMonster();
        }

        public void Run()
        {
            _character.Attack(_monster);
        }
    }
}
