using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int x, y,soma;

            Console.WriteLine("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            //para realizar a soma de x e y
            soma = x + y;

            Console.Write("Soma = " + soma);




        }
    }
}
