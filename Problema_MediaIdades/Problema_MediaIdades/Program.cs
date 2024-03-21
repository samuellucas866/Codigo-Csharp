using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int idade, nPessoas;
            double soma, media;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            //Laço para verificação das idades, caso o primeiro valor seja negativo, o programa informará 
            // que é "impossível calcular a média".

            if(idade < 0)
            {
                Console.Write("IMPOSSIVEL CALCULAR!!");
            }
            else
            {
                soma = 0;
                nPessoas = 0;

                while(idade > 0)
                {
                    //variável para armazenar a quantidade de idades digitadas
                    soma = soma + idade;
                    nPessoas++;

                    idade = int.Parse(Console.ReadLine());
                }

                media = soma / nPessoas;

                Console.Write("Media = " + media.ToString("F2", ci));
            }
        }
    }
}
