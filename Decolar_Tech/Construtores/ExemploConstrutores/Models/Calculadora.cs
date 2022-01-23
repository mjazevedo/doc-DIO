namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void Somar(int a, int b)
        {
            System.Console.WriteLine($"Adição: {a + b}");
        }

        public static void Subtrair(int a, int b)
        {
            System.Console.WriteLine($"Subtração: {a - b}");
        }
    }
}