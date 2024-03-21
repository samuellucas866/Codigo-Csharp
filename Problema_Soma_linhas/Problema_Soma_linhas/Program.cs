using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, m;

            double soma;

            Console.Write("Quantas linhas serão digitadas: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunas serão digitadas: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Laço para armazenar os valores dentro da matriz.
            double[,] mat = new double[m, n];

            for(int i = 0; i<m; i++)
            {
                Console.WriteLine("Digite os números da " + (i + 1) + "a linha: ");
                for(int j = 0; j<n; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine(),ci);
                }
            }

            //Laço para realizar a soma do vetor.

            double[] vet = new double[m];
            
            for(int i =0; i<m; i++)
            {
                soma = 0;
                for(int j =0; j < n; j++)
                {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }


            //Laço para mostrar o vetor gerado após a soma das linhas e coluna na matriz.


            Console.WriteLine("VETOR GERADO: ");
            for(int i =0; i < m; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", ci));
            }

        }
    }
}

