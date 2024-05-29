using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>
            {
                new Knight("Knight", 10, 20, new Sword("Sword")),
                new Assassin("Assassin", 15, 5, new Dagger("Dagger")),
                new Mage("Mage", 12, 15, new MagicStaff("MagicStaff")),
                new Archer("Archer", 12, 15, new Bow("Bow"))
            };

            Random random = new Random();
            int HeroAInt = random.Next(0, 4);
            int HeroBInt = random.Next(0, 4);
            while(HeroAInt == HeroBInt)
            {
                HeroBInt = random.Next(0, 4);
            }



            GameEngine gameEngine = new GameEngine()
            {
                HeroA = heroes[HeroAInt],
                HeroB = heroes[HeroBInt],
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}