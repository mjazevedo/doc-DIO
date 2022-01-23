namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalc();
        
        //Evento
        public static event DelegateCalc EventoCalc;
        public static void Somar(int a, int b)
        {
            if(EventoCalc != null)
            {
                System.Console.WriteLine($"Adição: {a + b}");
                EventoCalc();
            }
        }

        public static void Subtrair(int a, int b)
        {
            System.Console.WriteLine($"Subtração: {a - b}");
        }
    }
}