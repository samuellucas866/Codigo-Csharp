using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(String[] args)
        {
            int a, b;

            Console.WriteLine("Digite dois números inteiros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            
            //Laço para verificação se são multiplos.
            if(a%2==0 && b % 2 == 0)
            {
                Console.Write("São multiplos!!");
            }
            else
            {
                Console.Write("Não são multiplos!!");
            }
        }
    }
}