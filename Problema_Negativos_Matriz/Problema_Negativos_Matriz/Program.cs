using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            int n, m;

            Console.Write("Informe a quantidade de linhas que serão digitadas: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de colunas que serão digitadas: ");
            m = int.Parse(Console.ReadLine());


            //Laço para armazenar os valores dentro da matriz x.
            int[,] x = new int[n, m];

            for(int i =0; i<n; i++)
            {
                for(int j =0; j<m; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //laço para verificar os valores dentro do vetor menor que zero

            Console.WriteLine("Valores negativos: ");

            for(int i =0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    if (x[i,j] < 0)
                    {
                        Console.WriteLine(x[i, j]);
                    }
                }
            }

        }
    }
}
