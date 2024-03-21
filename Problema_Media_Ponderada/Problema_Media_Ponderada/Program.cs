using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, soma;
            double a, b, c, media;

            Console.Write("Digite a quantidade de casos que serão digitados: ");
            n = int.Parse(Console.ReadLine());

            //Laço para pegar o número de casos e mostrar a média ponderada de cada um.
            for(int i = 0; i <n; i++)
            {
                Console.WriteLine("Digite três números: ");
                a = double.Parse(Console.ReadLine(), ci);
                b = double.Parse(Console.ReadLine(),ci);
                c = double.Parse(Console.ReadLine(),ci);

                soma = 2 + 3 + 5;

                media = (a * 2 + b * 3 + c * 5) / soma;

                Console.WriteLine("Media = " + media.ToString("F1", ci));
            }
        }
    }
}