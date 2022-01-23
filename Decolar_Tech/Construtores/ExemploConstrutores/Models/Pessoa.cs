namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        public string Nome;
        public string SobreNome;

        // public Pessoa()
        // {
        //     Nome = string.Empty;
        //     SobreNome = string.Empty;
        // }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;

            System.Console.WriteLine("Construtor classe Pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {Nome} {SobreNome}");
        }
    }
}