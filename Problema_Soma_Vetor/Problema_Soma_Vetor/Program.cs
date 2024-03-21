using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double soma, media;

            Console.Write("Quantos números serão digitados: ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            //Laço para armazenar os valores dentro do vetor.
            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(),ci);   
            }

            //Laço para mostrar os valores dentro do vetor na ordem de armazenamento.
            Console.WriteLine();
            Console.Write("Valores = ");
            for(int i = 0; i <n; i++)
            {
                Console.Write(vet[i].ToString("F1") + " ",ci);
            }

            //Laço para somar os valores na posição do vetor.
            soma = 0;
            for(int i = 0; i <n; i++)
            {
                soma = soma + vet[i];
                
            }
            Console.WriteLine();
            Console.WriteLine("Soma = " + soma);

            media = soma / n;

            Console.WriteLine("Media = " + media.ToString("F2", ci));


            
            
        }
    }
}