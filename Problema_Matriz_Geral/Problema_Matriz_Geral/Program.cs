using System.Globalization;

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



            //Laço para armazenar os valores na matriz.
            double[,] x = new double[n, n];

            for(int i = 0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    x[i, j] = double.Parse(Console.ReadLine(),ci);
                }
            }


            //Laço para mostar a soma dos números positivos dentro da matriz.

            soma = 0;
            for(int i =0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (x[i,j] > 0)
                    {
                        soma = soma + x[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("SOMA DOS POSITIVOS: " + soma.ToString("F1",ci));

            Console.WriteLine();
            Console.WriteLine();

            //Laço para escolha da linha da matriz e imprimir os valores.

            Console.Write("ESCOLHA UMA LINHA: ");
            int linha = int.Parse(Console.ReadLine());

            for(int j =0; j<n; j++)
            {
                Console.Write("LINHA ESCOLHIDA: "+ x[linha, j].ToString("F1", ci)+" ");
            }

            Console.WriteLine();
            Console.WriteLine();


            //Laço para escolher a coluna e imprimir os valores
            //da coluna escolhida.


            Console.Write("ESCOLHA UMA COLUNA: ");
            int coluna = int.Parse(Console.ReadLine());

            for(int i =0; i<n; i++)
            {
                Console.Write("COLUNA ESCOLHIDA: "+x[i, coluna].ToString("F1", ci) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Laço para mostrar a diagonal da Matriz.

            Console.Write("DIAGONAL PRINCIPAL: ");

            for(int i =0; i<n; i++)
            {
                Console.Write(x[i, i].ToString("F1", ci) + " ");
            }



            //Laço  matriz alterada onde os números negativos serão
            //elevados ao quadrado.


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
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("MATRIZ ALTERADA: ");

            for(int i = 0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write(x[i, j].ToString("F1", ci)+ " ");
                }
                Console.WriteLine();
            }




        }
    }
}