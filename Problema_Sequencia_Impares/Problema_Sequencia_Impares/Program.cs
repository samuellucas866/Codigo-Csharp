using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int x;

            Console.Write("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());


            //Laço para pegar o valor de x e imprimir apenas os valores ímpares de 1 até x.
            for(int i = 1; i <= x; i++)
            {
                if( x % 2 != 0)
                {
                    Console.Write(i);
                }

            }

         

            
        }
    }
}
