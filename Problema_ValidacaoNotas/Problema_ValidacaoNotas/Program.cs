using System.Globalization;
using System.Numerics;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double n1, n2, media;

            //Laço para verificação das notas de 0 a 10. Caso o usuário digite valores acima ou abaixo.
            //O laço faz com que o usuário digite as informações corretamente.

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine(), ci);

            while(n1 < 0 || n1 > 10)
            {
                Console.Write("Valor inválido!! Tente novamente: ");
                n1 = double.Parse(Console.ReadLine(),ci);
            }

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine(),ci);

            while(n2 < 0 || n2 > 10)
            {
                Console.Write("Valor inválido!! Tente novamente: ");
                n2 = double.Parse(Console.ReadLine(),ci);
            }

            media = (n1 + n2) / 2;

            Console.Write("Media = " + media.ToString("F2", ci));
                

            

            
            }
        }
    }

