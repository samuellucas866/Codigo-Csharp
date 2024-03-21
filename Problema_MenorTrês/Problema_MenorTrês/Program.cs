using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int a, b, c,menor;

            Console.Write("Primeiro valor = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Segundo valor = ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Terceiro valor = ");
            c = int.Parse(Console.ReadLine());


            //Laço para verificar qual variável é menor.
            if(a<b && a < c)
            {
                menor = a;
            }
            else if(b<a && b < c)
            {
                menor = b;
            }
            else
            {
                menor = c;
            }

            Console.Write("MENOR = "+menor);
        }
    }
}