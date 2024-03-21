using System.Globalization;

namespace Programa
{
    class program
    {

        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            String nome1,nome2;
            int idade1,idade2;
            double media;
            
            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Nome: ");
            nome2 = Console.ReadLine();

            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            //linha da calculo da media de idades.
            media = (idade1 + idade2) / 2.0;


            Console.WriteLine("A idade média de "+ nome1 +" e "+nome2+
                " é de "+ media.ToString("F1",ci)+" anos");



        }

    }

}
