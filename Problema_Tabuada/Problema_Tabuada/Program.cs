using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;

            Console.Write("Deseja a tabuada de qual valor: ");
            n = int.Parse(Console.ReadLine());

            //Laço de repetição para pegar o valor de n e multiplicar pelo valor de i no laço.

            for( int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " X " + i + " = " + n * i);
            }
        }
    }
}
