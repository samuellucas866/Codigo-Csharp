using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double a, b, c;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(),ci);

            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(),ci);

            Console.Write("Coeficiente c: ");
            c  = double.Parse(Console.ReadLine(),ci);


            //Variável para pegar os valores e armazenar em delta confore equação.
            double delta = Math.Pow(b,2) - 4 * a * c;

            double x1, x2;
            
            //Laço para verificar se possui raízes reais ou não.
            if(delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2*a);

                Console.WriteLine("X1 = " + x1.ToString("F4",ci));
                Console.WriteLine("X2 = " + x2.ToString("F4", ci));
            }
            else
            {
                Console.WriteLine("ESTA ESQUAÇÃO NÃO POSSUI RAIZES REAIS!!");
            }
        }
    }
}
