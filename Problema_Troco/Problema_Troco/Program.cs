using System.Globalization;

namespace Programa
{
    class program
    {
        static  void Main(string[] args) 
        {

            CultureInfo ci = CultureInfo.InvariantCulture;
            double preco,dinheiro, troco;
            int quantidade;


            Console.Write("Preço unitário do produto = ");
            preco = double.Parse(Console.ReadLine(),ci);

            Console.Write("Quantidade comprada = ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido = ");
            dinheiro = double.Parse(Console.ReadLine(),ci);
            
            //Calculo para validação do troco
            troco = dinheiro - (preco * quantidade);

            Console.Write("Troco = " + troco.ToString("F2",ci));
        }
    }
}

