using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            char tipoCobaia;
            int n,qtdeCobaias, qtdeCoelhos, qtdeRatos, qtdeSapos,totalCobaias;
            double pCoelhos, pRatos, pSapos;
            
            Console.Write("Quantos casos de testes serão digitados: ");
            n = int.Parse(Console.ReadLine());

            qtdeCoelhos = 0;
            qtdeRatos = 0;
            qtdeSapos = 0;
            //Laço para pegar a quantidade de cobaias e o tipo para armazenar e mostrar o total
            //e o percentual de cada cobaia.
            for(int i = 0; i < n; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                qtdeCobaias = int.Parse(Console.ReadLine());

                Console.Write("Tipo de cobaia: ");
                tipoCobaia = char.Parse(Console.ReadLine());

                if(tipoCobaia == 'C')
                {
                    qtdeCoelhos = qtdeCobaias + qtdeCoelhos;
                }
                else if(tipoCobaia == 'R')
                {
                    qtdeRatos = qtdeCobaias + qtdeRatos;
                }
                else
                {
                    qtdeSapos = qtdeCobaias + qtdeSapos;
                }

            }
            //Calculos para apresentar na tela todo o relatório final.
            totalCobaias = qtdeCoelhos + qtdeRatos + qtdeSapos;

            pCoelhos = ((double)qtdeCoelhos / totalCobaias) * 100.0;
            pRatos = ((double)qtdeRatos / totalCobaias) * 100.0;
            pSapos = ((double)qtdeSapos / totalCobaias) * 100.0;

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO FINAL: ");
            Console.WriteLine("Total: " + totalCobaias + " cobaias.");
            Console.WriteLine("Total de Coelhos: " + qtdeCoelhos);
            Console.WriteLine("Total de Ratos: " + qtdeRatos);
            Console.WriteLine("Total de Sapos: "+qtdeSapos);
            Console.WriteLine("Percentual de Coelhos: " + pCoelhos.ToString("F2",ci));
            Console.WriteLine("Percentual de Ratos: " + pRatos.ToString("F2", ci));
            Console.WriteLine("Percentual de Sapos: " + pSapos.ToString("F2", ci));

        }
    }
}