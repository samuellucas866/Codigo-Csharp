using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, soma, npar;
            double media;

            Console.Write("Quantos elementos vai ter o vetor: ");
            n = int.Parse(Console.ReadLine());

            //Laço para armazenar os valores dentro do vetor.
            int[] x = new int[n];
            for(int i = 0; i<n; i++)
            {
                Console.Write("Digite um número: ");
                x[i] = int.Parse(Console.ReadLine());

            }


            //Laço para somar os valores pares para tirar a média dos valores pares
            npar = 0;
            soma = 0;
            
            for(int i = 0; i<n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    soma = soma + x[i];
                    npar++;
                }
            }
          
            //Estrutura condicional para verificar se há números pares digitados ou não.
            //Caso não tenha execulta o primeiro, caso tenho, pega o laço que armazenou a soma
            // e imprime a média dos valores pares digitados.

            if(npar == 0)
            {
                Console.Write("NENHUM NÚMERO PAR!!");
            }
            else
            {
                media = soma / npar;
                Console.Write("Media dos pares = "+media.ToString("F1",ci));
            }
           
            
           








        }
    }
}