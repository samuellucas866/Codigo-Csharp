using System.Globalization;

namespace Programa 
{ 
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, menores;
            double media, alturaTotal, percAltura;

            Console.Write("Quantos dados de pessoas serão digitados: ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];


            //Laço para armazenar os dados das pessoas dentro do vetor.

            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");
                
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine(), ci);

            }


            menores = 0;
            alturaTotal = 0;
            //Laço para verificar as pessoas menores de 16 anos.
            for(int i = 0; i < n; i++)
            {
                if (idade[i]< 16)
                {
                    menores++;
                }

                alturaTotal = alturaTotal + altura[i];

            }

            media = alturaTotal / n;
            percAltura = ((double)menores / n) * 100.0;

            Console.WriteLine("Altura média: "+media.ToString("F2",ci));
            Console.WriteLine("Pessoasa com menos de 16 anos: " + percAltura.ToString("F1", ci) + "%");
            
            //Laço para mostrar os nomes que tem a idade menor que 16 anos.
            for(int i = 0; i<n; i++)
            {
                if (idade[i] < 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            




        }
    }
}