using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, maisVelho, posMaior;

            Console.Write("Quantas pessoas serão digitadas: ");
            n = int.Parse(Console.ReadLine());


            string[] nomes = new string[n];
            int[] idades = new int[n];
            //Laço para armazenar os dados do nome e idades dentro do vetor.
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Digite os dados da " + (i + 1) + "a pessoa: ");

                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            maisVelho = idades[0];
            posMaior = 0;
            //Laço para verificação da pessoa mais velha.
            for(int i = 0; i<n; i++)
            {
                if (idades[i] > maisVelho)
                {
                    maisVelho = idades[i];
                    posMaior = i;
                }
            }

            Console.Write("PESSOA MAIS VELHA: " + nomes[posMaior]);

           

            

            
        }
    }
}