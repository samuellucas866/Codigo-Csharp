using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, x,dentro,fora;

            Console.Write("Quantos valores serão digitados: ");
            n = int.Parse(Console.ReadLine());

            
            //Laço para pegar os valores e caso esteja entre 10 e 20,
            //armazena na variável dentro e caso não esteja armazena fora.
            dentro = 0;
            fora = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                x = int.Parse(Console.ReadLine());

                if(x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine("Dentro = " + dentro);
            Console.WriteLine("Fora = " + fora);

        }
    }
}