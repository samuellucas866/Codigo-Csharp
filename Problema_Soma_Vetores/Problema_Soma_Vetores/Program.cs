using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;

            Console.Write("Quantos valores serão digitados em cada vetor: ");
            n = int.Parse(Console.ReadLine());


            //Laço para os valores serem armazenados no vetor A.

            int[] A = new int[n];

            Console.WriteLine("Digite os valores do vetor A: ");

            for (int i =0; i<n; i++)
            {
                
                A[i] = int.Parse(Console.ReadLine());

            }


            //Laço para os valores serem armazenados no vetor B.

            int[] B = new int[n];

            Console.WriteLine("Digite os valores do vetor B: ");

            for (int i = 0; i < n; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            //Laço para somar os valores dos vetores A+B.

            int[] C = new int[n];

            Console.WriteLine("VETOR RESULTANTE: ");

            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] + B[i];

                Console.WriteLine(C[i]);
            }
        }
    }
}