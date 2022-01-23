using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.helper;
using ExemploPOO.Interfaces;
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

            Corrente c = new Corrente();
            c.Creditar(300);

            c.ExibirSaldo();

            Computador comp = new Computador();
            Console.WriteLine(comp.ToString());

            ICalculadora calc2 = new Calculadora();
            System.Console.WriteLine(calc2.Somar(2,2));
            System.Console.WriteLine(calc2.Multiplicar(8,99));
            System.Console.WriteLine(calc2.Subtrair(90,77));

            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bckp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringConitinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};


            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivos(caminho);

            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(Path.Combine(caminhoPathCombine));

            //helper.ApagarDiretorio(caminhoPathCombine, true);

            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Testando escrita no arquivo");

            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringConitinuacao);

            //helper.LerArquivoStream(caminhoArquivo);

            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);

            //helper.CopiarArquivoStream(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            helper.DeletarArquivo(caminhoArquivoTesteCopia);

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
