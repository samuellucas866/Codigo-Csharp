using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;

            double d1, d2, d3, maior;

            Console.WriteLine("Digite as três distâncias: ");
            d1 = double.Parse(Console.ReadLine(),ci);
            d2 = double.Parse(Console.ReadLine(),ci);
            d3 = double.Parse(Console.ReadLine(),ci);


            //Laço para verificar qual das três distâncias será a maior.

            if(d1 > d2 && d1 > d3)
            {
                maior = d1;

            }
            else if(d2 > d1 && d2 > d3)
            {
                maior = d2;
            }
            else
            {
                maior = d3;
            }

            Console.Write("MAIOR DISTÂNCIA = " + maior.ToString("F2", ci));
        }
    }
}
