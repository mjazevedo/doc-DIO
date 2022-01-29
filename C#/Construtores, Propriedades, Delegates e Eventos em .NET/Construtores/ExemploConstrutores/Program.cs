using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int a, int b);
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

            const double pi = 3.14;
            System.Console.WriteLine(pi);

            Operacao op = new Operacao(Calculadora.Somar);
            //Operacao op = Calculadora.Somar;
            op += Calculadora.Subtrair; // Ordem FIFO - Multi Cast Delegate 

            op.Invoke(20,15);
            
            //op(30,90)

            Matematica mat = new Matematica(10, 80);
            mat.Somar();
            
        }
    }
}
