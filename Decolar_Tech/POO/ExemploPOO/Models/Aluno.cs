using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine("Olá, meu nome é {0} e tenho {1} anos. Sou um aluno de nota {2}", Nome, Idade, Nota);
        }

    }
}