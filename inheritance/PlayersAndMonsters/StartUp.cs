namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Anton", 200);
            System.Console.WriteLine(hero);
            Elf hero1 = new Elf("Anton", 200);
            System.Console.WriteLine(hero1);
            Wizard hero2 = new Wizard("Anton", 200);
            System.Console.WriteLine(hero2);
            Knight hero3 = new Knight("Anton", 200);
            System.Console.WriteLine(hero3);
            DarkKnight hero4 = new DarkKnight("Anton", 200);
            System.Console.WriteLine(hero4);
            MuseElf hero5 = new MuseElf("Anton", 200);
            System.Console.WriteLine(hero5);
            SoulMaster hero6 = new SoulMaster("Anton", 200);
            System.Console.WriteLine(hero6);
            DarkWizard hero7 = new DarkWizard("Anton", 200);
            System.Console.WriteLine(hero7);
            BladeKnight her8 = new BladeKnight("Anton", 200);
            System.Console.WriteLine(her8);
        }
    }
}