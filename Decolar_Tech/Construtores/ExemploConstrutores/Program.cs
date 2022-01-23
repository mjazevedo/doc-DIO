using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("José", "Alves", "Matemática");
            // p1.Nome = "Matheus";
            // p1.SobreNome = "Azevedo";

            p1.Apresentar();

            Pessoa p2 = new Pessoa("João", "Azevedo");
            p2.Apresentar();

            Log log = Log.GetInstance();

            log.propLog = "Teste Instância";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log.propLog);

            Data data = new Data();
            data.SetMes(12);
            data.SetMes(65);

            data.ApresentarMes();

            data.Mes = 10;
            System.Console.WriteLine(data.Mes);
        }
    }
}
