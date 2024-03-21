using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            

            int n, m;

            Console.Write("Quantas linhas vai ter a matriz: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunas vai ter cada matriz: ");
            m = int.Parse(Console.ReadLine());


            //Laço para armazenar os valores na matriz A
            int[,] A = new int[n, m];

            Console.WriteLine("Digite os valores da matriz A: ");
            for(int i =0; i<n; i++)
            {
                for(int j =0; j<m; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            //Laço para armazenar os valores na matriz B.
            int[,] B = new int[n, m];

            Console.WriteLine("Digite os valores da matriz B: ");
            for(int i =0; i<n; i++)
            {
                for(int j =0; j<m; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    B[i,j] = int.Parse(Console.ReadLine());
                }
            }



            //Laço para realizar a soma entra a matriz A e B;
            //Armazenando os valores na matriz C.
            int[,] C = new int[n, m];

            Console.WriteLine("MATRIZ SOMA: ");

            for(int i=0; i<n; i++)
            {
                for(int j =0; j<m; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }







        }
    }
}