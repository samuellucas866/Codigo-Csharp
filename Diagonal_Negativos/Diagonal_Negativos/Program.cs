using System.Globalization;
using System.Security.Cryptography;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            int n, cont;

            Console.Write("Qual a ordem da matriz: ");
            n = int.Parse(Console.ReadLine());


            int[,] mat = new int[n,n];

            //laço para adicionar os elementos nas posições da linha i e coluna j.
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j+ "]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            //laço para pegar a diagonal da matriz de acordo com as posições da linha
            // i colocando o valor de i na coluna j.
            Console.Write("Diagonal Principal: ");
            for(int i =0; i<n; i++)
            {
                    Console.Write(mat[i, i]+ " ");
                
            }

            Console.WriteLine();


            cont = 0;
            //laço para mostrar a quantidade dos números negativos dentro da matriz.
            
            for(int i= 0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NÚMEROS NEGATIVOS: "+cont);
        }
    }
}