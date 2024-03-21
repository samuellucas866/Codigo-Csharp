using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double valor;
            int quantidade;
            char codigo;

            Console.Write("Código do produto comprado: ");
            codigo = char.Parse(Console.ReadLine());

            //Laço para verificação do código e informar o valor a pagar.
            valor = 0;
            if(codigo == '1')
            {
                Console.Write("Quantidade comprada: ");
                quantidade = int.Parse(Console.ReadLine());

                valor = quantidade * 5.00;
                Console.Write("Valor a pagar: R$" + valor.ToString("F2", ci));
            }
            else if(codigo == '2')
            {
                Console.Write("Quantidade comprada: ");
                quantidade = int.Parse(Console.ReadLine());

                valor = quantidade * 3.50;
                Console.Write("Valor a pagar: R$" + valor.ToString("F2", ci));
            }
            else if(codigo == '3')
            {
                Console.Write("Quantidade comprada: ");
                quantidade = int.Parse(Console.ReadLine());
                
                valor = quantidade * 4.80;
                Console.Write("Valor a pagar: R$" + valor.ToString("F2", ci));

            }
            else if(codigo == '4')
            {
                Console.Write("Quantidade comprada: ");
                quantidade = int.Parse(Console.ReadLine());

                valor = quantidade * 8.90;
                Console.Write("Valor a pagar: R$" + valor.ToString("F2", ci));
            }
            else if(codigo == '5')
            {
                Console.Write("Quantidade comprada: ");
                quantidade = int.Parse(Console.ReadLine());

                valor = quantidade * 7.32;
                Console.Write("Valor a pagar: R$" + valor.ToString("F2", ci));
            }
        }
    }
}
