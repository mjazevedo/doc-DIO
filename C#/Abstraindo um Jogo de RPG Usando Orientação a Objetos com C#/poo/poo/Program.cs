using poo.src.Entities;
using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 12, "Knight");
            //Hero enemy = new Hero("Wolf", 20, "Devil");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            //hero.Name = "Arus";
            //hero.Level = 2;
            //hero.HeroType = "Knight";

            Console.WriteLine(hero);
            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
            //Console.WriteLine(enemy);

            Random random = new Random();
            int attack = random.Next(1, 10);

            Console.WriteLine(wizard.Attack(attack));
        }
    }
}
