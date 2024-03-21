using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int n, i;
            double soma, media;

            Console.WriteLine("Quantos números serão digitados: ");
            n = int.Parse(Console.ReadLine());

            //laço para armazenar os valores dentro do vetor.
            double[] vet = new double[n];
            
            for(i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(),ci);
                
            }

            //laço para mostrar os valores digitados e armazenados nos vetores.

            Console.WriteLine();
            Console.Write("VALORES = ");

            for(i=0; i<n; i++)
            {
                Console.Write(vet[i].ToString("F1",ci) + " ");
            }

            Console.WriteLine();

            //laço para fazar a soma dos vetores.
           
            soma = 0;
            for (i=0; i<n; i++)
            {
                soma = soma + vet[i];
            }

            Console.Write("SOMA = "+ soma.ToString("F1",ci));

            Console.WriteLine();
            //laço para pegar a soma dos vetores e calcula a media.
            media = soma / n;

            Console.Write("MEDIA = " + media.ToString("F1",ci));
        }
    }
}
