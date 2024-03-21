using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo ci = CultureInfo.InvariantCulture;

        char escala;
        double C, F;

        Console.Write("Você vai digitar a temperatura em qual escala(C/F)? ");
        escala = Char.Parse(Console.ReadLine());

        //Laço de repetição para conversão das escalas de temperaturas. 
        if (escala == 'F')
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            F = double.Parse(Console.ReadLine(),ci);

            C = 5.0 / 9.0 * (F - 32.0);
            Console.Write("Temperatura equivalente: "+C.ToString("F2",ci));
        }
        else if(escala == 'C')
        {
            Console.Write("Digite a temperatura em Celsius: ");
            C = double.Parse(Console.ReadLine(),ci);

            F = C * 9.0 / 5.0 + 32.0;

            Console.Write("Temperatura equivalente: "+F.ToString("F2",ci));
        }
    }
}