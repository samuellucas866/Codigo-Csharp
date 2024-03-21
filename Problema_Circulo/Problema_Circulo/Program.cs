using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double raio, area;

            Console.Write("Digite o valor do raio do círculo: ");
            raio = double.Parse(Console.ReadLine(),ci);

            //Metodo Math.PI da própria biblioteca para informar o valor de pi.
            //Metodo Math.Pow da própria biblioteca para elevar ao quadrado o valor do raio.
            area = Math.PI * Math.Pow(raio, 2);

            Console.Write("AREA = "+area.ToString("F3",ci));

        }
    }
}
