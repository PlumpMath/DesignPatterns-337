using System;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main( string[] args )
        {
            var sciFiClient = new Client(new SciFiCharacterFactory());

            sciFiClient.Run();

            var fantasyClient = new Client(new FantasyCharacterFactory());

            fantasyClient.Run();

            Console.ReadKey();
        }
    }
}
