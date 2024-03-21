using System.ComponentModel.Design;
using System.Globalization;


namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            int a, b, c,menor;

            Console.Write("Primeiro Valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Terceiro Valor: ");
            c = int.Parse(Console.ReadLine());

            //if encadeado para verificação do menor número e imprimir o menor entre os
            //valores de a,b,c.

            if (a < b && a < c)
            {
                menor = a;

            }
            else if (b < c )
            {
                menor = b; 
            }

            else
            {
                menor = c;
            }

            Console.Write("Menor = "+menor);

        }
    }
}
