using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int x,soma;

            Console.Write("Digite um número inteiro: ");
            x = int.Parse(Console.ReadLine());

            //Laço para pegar o valor inserido pelo usuário, verifica se é diferente de zero.
            //Em seguida ele verifica no if, se é diferente de zero. Para trabalhar também com os números ímpares.
            //Faz a soma com os pares consecutivos e imprime em tela.
            while (x != 0)
            {
                if(x%2 != 0)
                {
                    x++;
                }

                soma = 5 * x + 20;

                Console.WriteLine("Soma = " + soma);

                Console.Write("Digite um número inteiro: ");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
