using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci  = CultureInfo.InvariantCulture;

            int n;

            Console.Write("Qual a ordem da matriz: ");
            n = int.Parse(Console.ReadLine());



            //Laço para armazenar os valores dentro da matriz.

            int[,] x = new int[n, n];

            for(int i = 0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //laço para somar os elementos acima da diagonal.

            int soma = 0;
            for(int i = 1; i<n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        soma = soma + x[i, j];

                    }
                }
            }

            Console.Write("Soma dos elementos acima da diagonal: "+soma);
        }
    }
}