using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, cont;

            Console.Write("Quantos números serão digitados: ");
            n = int.Parse(Console.ReadLine());

           
            int[] x = new int[n];

            //Laço para armazenar os valores no vetor

            for(int i = 0; i <n; i++)
            {
                Console.Write("Digite um número: ");
                x[i] = int.Parse(Console.ReadLine());
            }


            //Laço para verificar os números pares dentro do vetor.
            cont = 0;
            Console.WriteLine("Números Pares: ");
            for(int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    Console.Write(x[i] + " ");
                    cont++;

                }
            }
            Console.WriteLine();
            Console.Write("Quantidade de pares: " + cont);

            



        }
    }
}