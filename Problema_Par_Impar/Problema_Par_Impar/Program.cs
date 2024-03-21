using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n,x;

            Console.Write("Quantos casos serão digitados: ");
            n = int.Parse(Console.ReadLine());

            //Laço para verificar se os valores digitados são nulos,ímpares e pares.
            for( int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                x = int.Parse(Console.ReadLine());

                if(x% 2 != 0 && x > 0)
                {
                    Console.WriteLine("IMPAR POSITIVO!");
                }
                else if(x %2 == 0 && x >0)
                {
                    Console.WriteLine("PAR POSITIVO!");
                }
                else if(x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("PAR NEGATIVO!");
                }
                else if(x%2!=0 && x < 0)
                {
                    Console.WriteLine("IMPAR NEGATIVO");
                }
                else if(x == 0)
                {
                    Console.WriteLine("NULO!");
                }
            }

        }
    }
}