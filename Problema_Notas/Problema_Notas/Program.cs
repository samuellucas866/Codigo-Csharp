using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double n1, n2, media;
           

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine(),ci);

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine(),ci);


            //Condição para verificar se o aluno está aprovado ou reprovado.
            media = n1 + n2;

            if(media < 60)
            {
                Console.WriteLine("Nota = " + media.ToString("F1",ci));
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("Nota = " + media.ToString("F1",ci));
                Console.WriteLine("APROVADO");
            }
        }
    }

}