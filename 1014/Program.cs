namespace _1014
{
    class Mob { }
    class MobBos { }
    class MobEnemy { }

    class  Player
    {
        public void Attack(Mob m, int attack)
        {
            Console.WriteLine("Attack mob");
        }
        public void Attack(MobBos m, int attack, int bo)
        {
            Console.WriteLine("Attack MobBos");
        }
        public void Attack(MobEnemy m)
        {
            Console.WriteLine("MobEnemy MobBos");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Mob mob = new Mob();
            MobBos mobBos = new MobBos();
            MobEnemy mobEnemy = new MobEnemy();


            var ret = MyMath.Sum(1, 100);
            Console.WriteLine($"sum: {ret}");

            var ret2 = MyMath.Multi(1, 15);
            Console.WriteLine($"Multi: {ret2}");
        }
    }
}
