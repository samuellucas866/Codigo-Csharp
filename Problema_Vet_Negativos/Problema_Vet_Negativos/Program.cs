using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            int n;

            
            Console.Write("Quantos números serão digitados: ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            //Laço para armazenar os números dentro do vetor.
            for (int i = 0; i< n; i++) 
            {
                Console.Write("Digite um número: ");
                
                vet[i] = double.Parse(Console.ReadLine());
                
            }

            //Laço para verificar se dentro do vetor há números negativos.
            Console.WriteLine();
            Console.WriteLine("NÚMEROS NEGATIVOS: ");
            for(int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}