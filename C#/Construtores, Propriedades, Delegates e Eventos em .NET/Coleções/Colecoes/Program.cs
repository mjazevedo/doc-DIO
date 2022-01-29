using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayNums = new int[9] {1, 4, 4, 5, 0, 8, 15, 15, 100};

            var minimo = arrayNums.Min();
            var maximo = arrayNums.Max();
            var medio = arrayNums.Average();

            System.Console.WriteLine($"Mímino: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");

            var soma = arrayNums.Sum();
            System.Console.WriteLine($"Soma: {soma}");
            var arrayUnico = arrayNums.Distinct().ToArray();
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNums)}");
            System.Console.WriteLine($"Array distinct: {string.Join(", ", arrayUnico)}");


            var numParesQuery = 
                    from num in arrayNums
                    where num % 2 == 0
                    orderby num
                    select num;

            var numParesMetodos = arrayNums.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine("Números pares query: " + string.Join(", ", numParesQuery));
            System.Console.WriteLine("Números pares método: " + string.Join(", ", numParesMetodos));



            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");
            //estados.Add("MG", "");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // System.Console.WriteLine("Removendo o valor");

            // string valueProcurado = "MG";
            // estados.Remove(valueProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado = "BA";

            // System.Console.WriteLine("Valor original:");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - Teste atualização";
            // System.Console.WriteLine("Valor Atualizado:");

            // System.Console.WriteLine(estados[valorProcurado]);

            // var teste = estados["SC"];

            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            // }

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");

            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // while(pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");
            //     System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            // }

            //     System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

            // OperacoesLista opList = new OperacoesLista();
            // List<string> estado = new List<string> {"SP", "MG", "BA"};
            // string[] estadoArr = new string[2] {"SC", "MT"};

            // // estado.Add("SP");
            // // estado.Add("MG");
            // // estado.Add("BA");

            // System.Console.WriteLine("Quantidade de elementos da lista: {0}", estado.Count);

            // opList.ImprimirListStr(estado);
            // // System.Console.WriteLine("Removendo o elemento:");
            // // estado.Remove("MG");

            // // estado.AddRange(estadoArr); // Adiciona Elementos no final da coleção
            // estado.Insert(1, "RJ");
            // opList.ImprimirListStr(estado);

            // System.Console.WriteLine("Usando foreach:");
            // foreach (var item in estado)
            // {
            //     System.Console.WriteLine(item);   
            // }

            // System.Console.WriteLine("Usando for:");
            // for (int i = 0; i < estado.Count; i++)
            // {
            //     System.Console.WriteLine($"Índice {i}: {estado[i]}");
            // }

            
            // int[] arrayInt = new int[3];

            // arrayInt[0] = 10;
            // arrayInt[1] = 28;
            // arrayInt[2] = 35;

            
            // //arrayInt[3] = 40;

            // // System.Console.WriteLine("Percorrendo Array pelo For:");
            // // for (int i = 0; i < arrayInt.Length; i++)
            // // {
            // //     System.Console.WriteLine(arrayInt[i]);
            // // }
            
            // // System.Console.WriteLine("Percorrendo Array pelo Foreach:");
            // // foreach (int item in arrayInt)
            // // {
            // //     System.Console.WriteLine(item);
            // // }

            // int[,] mat = new int[4,2]
            // {
            //     {8, 8},
            //     {10, 20},
            //     {50, 100},
            //     {90, 120}
            // };

            // for(int i = 0; i < mat.GetLength(0); i++)
            // {
            //     for(int j = 0; j < mat.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(mat[i,j]);
            //     }
            // }

            // OperacoesArray op = new OperacoesArray();
            // int[] array  = new int[5] {6, 3, 8, 1, 9};
            // int[] arrCopy = new int[10];

            // int valorProcurado = 9;
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // System.Console.WriteLine("Array Original:");
            // op.ImprimirArray(array);

            // //op.OrdenarBubbleSort(ref array); // Fazendo manualmente
            // //op.Ordenar(ref array); // Método Sort c# 

            // System.Console.WriteLine("Array Ordenado:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrCopy);

            // op.Copiar(ref array, ref arrCopy);
            // System.Console.WriteLine("Array após a cópia:");            
            // op.ImprimirArray(arrCopy);

            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            // if(TodosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // int Indice = op.Obterindice(array, valorProcurado);

            // if(Indice > -1)
            // {
            //     System.Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado, Indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }

            // System.Console.WriteLine("Capacidade atual do array: {0}", array.Length);

            // op.RedimensionarArray(ref array, array.Length * 2);
            // System.Console.WriteLine("Capacidade atual do array após redimensionar: {0}", array.Length);

            // string[] arrayStr = op.ConverterParaArrayString(array);
        }
    }
}
