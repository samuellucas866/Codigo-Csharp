using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double valorExtra,franquia,valorPago;

            int minutos;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());


            //Laço para verificar se os minutos excedem a franquia.
            franquia = 50;
            valorExtra = 2;

            if(minutos <= franquia)
            {
                valorPago = franquia;
            }
            else
            {
                valorPago = franquia + (minutos - 100) * valorExtra;
            }

            Console.Write("VALOR A PAGAR = R$" + valorPago.ToString("F2", ci));

        }
    }
}