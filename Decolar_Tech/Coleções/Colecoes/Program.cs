using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesLista opList = new OperacoesLista();
            List<string> estado = new List<string> {"SP", "MG", "BA"};
            string[] estadoArr = new string[2] {"SC", "MT"};

            // estado.Add("SP");
            // estado.Add("MG");
            // estado.Add("BA");

            System.Console.WriteLine("Quantidade de elementos da lista: {0}", estado.Count);

            opList.ImprimirListStr(estado);
            // System.Console.WriteLine("Removendo o elemento:");
            // estado.Remove("MG");

            // estado.AddRange(estadoArr); // Adiciona Elementos no final da coleção
            estado.Insert(1, "RJ");
            opList.ImprimirListStr(estado);

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
