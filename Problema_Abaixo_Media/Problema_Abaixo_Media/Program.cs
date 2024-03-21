using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double soma, media;

            Console.Write("Quantos elementos vai ter o vetor: ");
            n = int.Parse(Console.ReadLine());

            double[] A = new double[n];

            //Laço para armazenar os valores dentro do vetor.
            for(int i =0; i<n; i++)
            {
                Console.Write("Digite um número: ");
                A[i] = double.Parse(Console.ReadLine(),ci);
            }

            soma = 0;
            //Laço para realizar a soma dos valores armazenados no vetor.
            for(int i = 0; i<n; i++)
            {
                soma = soma + A[i];
            }

            media = soma / n;

            Console.WriteLine("Media do vetor = " + media.ToString("F3", ci));

            //Laço para informar os valores que estão abaixo da média dentro do vetor.
            Console.WriteLine("ELEMENTOS QUE ESTÃO ABAIXO DA MEDIA: ");
            for(int i = 0; i < n; i++)
            {
                if (A[i] < media)
                {
                    Console.WriteLine(A[i].ToString("F1",ci));
                }
            }
        }
    }
}