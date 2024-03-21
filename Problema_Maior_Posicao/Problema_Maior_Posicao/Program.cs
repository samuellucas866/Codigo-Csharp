using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;

            Console.Write("Quantos números serão digitados: ");
            n = int.Parse(Console.ReadLine());

            double[] x = new double [n];

            //Laço para armazenar os números digitados dentro do vetor.

            for(int i = 0; i<n; i++)
            {
                Console.Write("Digite um número: ");
                x[i] = double.Parse(Console.ReadLine(),ci);
            }

            double Maior = x[0];
            int posMaior = 0;
            //Laço para verificar dentro do vetor qual o maior elemento na posição do vetor.
            //E para informar a posição do número armazenado no vetor.
            for (int i = 0; i < n; i++)
            {
                if (x[i] > Maior)
                {
                    Maior = x[i];
                    posMaior = i;
                }
            }

            Console.Write("MAIOR VALOR = " + Maior.ToString("F1", ci));

            Console.WriteLine();
            Console.Write("POSICAO DO MAIOR VALOR: "+posMaior);
           

        }
    }
}