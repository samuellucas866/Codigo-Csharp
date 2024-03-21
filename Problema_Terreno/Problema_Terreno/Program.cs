using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double largura, comprimento, metroQuadrado, area, preco;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite o valor do metro quadrado: ");
            metroQuadrado = double.Parse(Console.ReadLine(),ci);

            //Calculo da área do terreno.
            area = largura * comprimento;

            Console.WriteLine("Area do terreno = "+area.ToString("F2",ci));

            //Calculo do preço do terreno.
            preco = metroQuadrado * area;

            Console.WriteLine("Preço do terreno = "+preco.ToString("F2",ci));
        }
    }
}
