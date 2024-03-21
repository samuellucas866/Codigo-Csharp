using System.Globalization;


namespace Programa
{

    class program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;

            double a, b, h, p, d;

            Console.Write("Base do retangulo: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Altura do retangulo: ");
            a = double.Parse(Console.ReadLine());


            // calculos para altura, perimetro e diagonal do retangulo

             h = a * b;

             p = 2*(a + b);

            d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));


            Console.WriteLine("Area = " + h.ToString("F4",ci));

            Console.WriteLine("PERIMETRO = " + p.ToString("F4",ci));

            Console.WriteLine("DIAGONAL = " + d.ToString("F4",ci));
            

            
        }

    }
}
