using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n,maiorPosicao;

            Console.Write("Qual será a ordem da matriz: ");
            n = int.Parse(Console.ReadLine());

            //Laço para armazenar os valores dentro da matriz.

            int[,] x = new int[n,n];

            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //Laço para verificar qual elemento é maior de cada Linha

            int[] maiorLinha = new int[n];

            for(int i=0; i<n; i++)
            {
                maiorPosicao = x[i, 0];
                for(int j =0; j<n; j++)
                {
                    if (x[i,j] > maiorPosicao)
                    {
                        maiorPosicao = x[i, j];
                    }
                }

                maiorLinha[i] = maiorPosicao;
            }


            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");

            for(int i =0; i<n; i++)
            {
                Console.WriteLine(maiorLinha[i]);
            }




        }
    }
}