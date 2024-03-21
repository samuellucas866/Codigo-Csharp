using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int x, y;

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            //Laço repetição para verificação dos números crescentes ou decrescente.
            //Caso os números forem iguais, o programa será encerrado.
            while (x != y)
            {

                if (x < y)
                {
                    Console.WriteLine("Crescente");
               
                }
                
                else if (x > y)
                {
                    Console.WriteLine("Decrescente");
                      
                }

                Console.WriteLine("Digite outros dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }
        }
    }
}