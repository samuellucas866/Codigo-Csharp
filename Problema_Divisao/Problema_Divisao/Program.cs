using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] agrs)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int x;
            double n, d, divisao;

            Console.Write("Qual a quantidade de casos: ");
            x = int.Parse(Console.ReadLine());

            //Laço para realizar a divisão entre dois números.
            //Caso o denominador igual a zero, imprimir em tela que é impossível
            //realizar divisão.
            for(int i = 0; i < x; i++)
            {
                Console.Write("Digite o numerador: ");
                n = double.Parse(Console.ReadLine(), ci);

                Console.Write("Digite o denominador: ");
                d = double.Parse(Console.ReadLine(), ci);

                if(d == 0)
                {
                    Console.WriteLine("IMPOSSÍVEL CALCULAR!!");
                }
                else                 {
                    divisao = n / d;
                    Console.WriteLine("Divisão = " + divisao.ToString("F2", ci));
                }
              
            }
        }
    }
}