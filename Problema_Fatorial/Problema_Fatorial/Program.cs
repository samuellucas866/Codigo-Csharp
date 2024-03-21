using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, fat;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            //Laço para pegar o valor de n e apresentar o valor do 
            //fatorial digitado.
            fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.Write("Fatorial = "+fat);
                
        }
    }
}