using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[3];

            arrayInt[0] = 10;
            arrayInt[1] = 28;
            arrayInt[2] = 35;

            
            //arrayInt[3] = 40;

            // System.Console.WriteLine("Percorrendo Array pelo For:");
            // for (int i = 0; i < arrayInt.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInt[i]);
            // }
            
            // System.Console.WriteLine("Percorrendo Array pelo Foreach:");
            // foreach (int item in arrayInt)
            // {
            //     System.Console.WriteLine(item);
            // }

            int[,] mat = new int[4,2]
            {
                {8, 8},
                {10, 20},
                {50, 100},
                {90, 120}
            };

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    System.Console.WriteLine(mat[i,j]);
                }
            }
            
        }
    }
}
