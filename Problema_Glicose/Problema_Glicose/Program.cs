using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double glicose;
            
            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(),ci);

            //Laço para verificação da classificação glicose.
            Console.Write("Classificação: ");            
            if(glicose <= 100)
            {
                
                Console.Write("Normal");
            }
            else if(glicose <= 140)
            {
                Console.Write("Elevado");
            }
            else
            {
                Console.Write("Diabetes");
            }
        }
    }
}