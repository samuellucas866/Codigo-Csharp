using System.Globalization;
using System.Text.RegularExpressions;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double soma;

            Console.Write("Qual a ordem da matriz: ");
            n = int.Parse(Console.ReadLine());

            //Laço para armazenar os valores dentro da matriz.

            double[,] x = new double[n, n];

            for(int i =0; i < n; i++)
            {
                for(int j =0; j <n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    x[i, j] = double.Parse(Console.ReadLine(),ci);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            //Laço para realizar a soma dos números positivos dentro da matriz.
            soma = 0;
            
            for(int i =0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (x[i,j]> 0)
                    {
                        soma = soma + x[i, j];
                        
                    }
                }
            }

            Console.Write("SOMA DOS POSITIVOS: "+soma.ToString("F1",ci));

            Console.WriteLine();
            Console.WriteLine();

            //Laço para escolher uma linha e informar os números da coluna na matriz.
            
            Console.Write("ESCOLHA UMA LINHA: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");
            for(int j =0; j<n; j++)
            {
                Console.Write(x[linha, j].ToString("F1", ci)+" ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //laço para escolher uma coluna e informar os números da coluna na matriz.

            Console.Write("ESCOLHA UMA COLUNA: ");
            int coluna = int.Parse(Console.ReadLine());

            Console.Write("COLUNA ESCOLHIDA: ");
            for(int i =0; i<n; i++)
            {
                Console.Write(x[i,coluna].ToString("F1",ci)+" ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Laço para mostrar a diagonal principal do vetor.
            
            Console.Write("DIAGONAL PRINCIPAL: ");
            for(int i =0; i<n; i++)
            {
                Console.Write(x[i, i].ToString("F1", ci)+" ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //laço para pegar os valores negativos dentro da matriz e
            //elevar os valores ao quadrado.

            for(int i =0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (x[i,j] < 0)
                    {
                        x[i, j] = Math.Pow(x[i, j], 2);
                    }
                }
            }


            Console.WriteLine("MATRIZ ALTERADA: ");

            for(int i =0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    Console.Write(x[i, j].ToString("F1", ci)+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
