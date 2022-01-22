using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pe1 = new Pessoa();
            pe1.Nome = "André";
            pe1.Idade = 23;

            pe1.Apresentar();

            //Exemplo Polimorfismo em tempo de execução
            Aluno a1 = new Aluno();
            a1.Nome = "João Marques";
            a1.Idade = 19;
            a1.Nota = 10;

            a1.Apresentar();

            Professor p1 = new Professor();
            p1.Nome = "Antônio Fernandes";
            p1.Salario = 4000.00;
            p1.Idade = 38;

            p1.Apresentar();
            
            //Exemplo de polimorfismo em tempo de compilação
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(4, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(4, 10, 10));

    
            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,20);
            // System.Console.WriteLine($"Área = {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            // System.Console.WriteLine($"Área = {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Matheus";
            // p1.Idade = 21;

            // p1.Apresentar();
        }
    }
}
