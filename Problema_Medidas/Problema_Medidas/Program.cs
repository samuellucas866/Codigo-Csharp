using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double a, b, c,areaQuadrado,areaTriangulo,areaTrapezio;

            Console.Write("Digite a medida de A: ");
            a = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite a medida de B: ");
            b = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite a medida de C: ");
            c = double.Parse(Console.ReadLine(),ci);

            //Para fazer os calculos das medidas de cada objeto geométrico.
            areaQuadrado = Math.Pow(a, 2);
            areaTriangulo = (a * b) / 2;
            areaTrapezio = (a + b) * c / 2;

            Console.WriteLine("AREA DO QUADRADO = "+areaQuadrado.ToString("F4",ci));
            Console.WriteLine("AREA DO TRIANGULO = "+areaTriangulo.ToString("F4",ci));
            Console.WriteLine("AREA DO TRAPEZIO = "+areaTrapezio.ToString("F4",ci));


        }
    }
}