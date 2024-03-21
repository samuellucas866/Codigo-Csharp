using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double x, y;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite o valor de Y: ");
            y = double.Parse(Console.ReadLine(),ci);

            //Laço de repetição para verificar em qual quadrante está os valores de X e Y.
            if(x > 0 && y > 0)
            {
                Console.Write("Q1");
            }
            else if(x < 0 && y > 0)
            {
                Console.Write("Q2");
            }
            else if(x <0 && y < 0)
            {
                Console.Write("Q3");
            }
            else if(x>0 && y<0)
            {
                Console.Write("Q4");
            }
            else if(x == 0 && y >0)
            {
                Console.Write("Eixo Y");
            }
            else if(y == 0 && x > 0)
            {
                Console.Write("Eixo X");
            }
            else
            {
                Console.Write("Origem");
            }
        }
    }
}