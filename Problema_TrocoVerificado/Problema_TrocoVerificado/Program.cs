using System.Globalization;

namespace Progama
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double precoUni, valorRecebido, troco,faltam;
            int quantidade;

            Console.Write("Preço unitário do produto: ");
            precoUni = double.Parse(Console.ReadLine(), ci);

            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            valorRecebido = double.Parse(Console.ReadLine(),ci);


            //Laço de repetição para verificação de troco ou dinheiro faltante.
            if(precoUni*quantidade > valorRecebido)
            {
                faltam = precoUni * quantidade - valorRecebido;
                Console.Write("DINHEIRO INSUFICIENTE! FALTAM R$"+faltam.ToString("F2",ci));

            }
            else
            {
                troco = valorRecebido - (precoUni * quantidade);
                Console.Write("Troco = R$" + troco.ToString("F2", ci));
            }


        }
    }
}
