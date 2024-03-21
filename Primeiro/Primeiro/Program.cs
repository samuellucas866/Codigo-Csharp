using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Primeiro
{
     class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;
            int m,n,i,j;


            Console.WriteLine("Digite a quantidade de linhas da matriz: ");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas da matriz: ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m,n];
            
            for(i = 0; i < m; i++)
            {
                for(j=0; j < n; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA: ");
            for(i = 0; i < m;i++)
            {
                for(j= 0; j < n; j++)
                {
                    Console.Write(mat[i,j]+ " ");
                }
                Console.WriteLine();
            }


            


        }
    }
}
