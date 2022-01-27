using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListStr(List<string> lista)
        {
            System.Console.WriteLine("Usando for:");
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice = {i}, Valor = {lista[i]}");
            }
        }
    }
}