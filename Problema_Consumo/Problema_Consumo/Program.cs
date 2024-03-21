using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int distancia;
            double combustivel, consumo;

            Console.Write("Distancia percorrida = ");
            distancia = int.Parse(Console.ReadLine());

            Console.Write("Combustível gasto: ");
            combustivel = double.Parse(Console.ReadLine(),ci);

            //Para calcular o consumo percorrido pelo veículo.

            consumo = distancia / combustivel;

            Console.Write("Consumo médio = "+consumo.ToString("F3",ci));
        }
    }

}
