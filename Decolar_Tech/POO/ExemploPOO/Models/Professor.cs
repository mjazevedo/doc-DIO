using System;
namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine("Olá, meu nome é {0} e tenho {1} anos. Ganho R${2}", Nome, Idade, Salario);
        }
    }
}