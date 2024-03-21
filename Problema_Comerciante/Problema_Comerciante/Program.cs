using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, abaixo, entre, acima;
            double lucro, pLucro, totalLucro, totalCompra, totalVenda;

            Console.Write("Quantos produtos serão digitados: ");
            n = int.Parse(Console.ReadLine());


            //Laço para armazenar os valores dentro do vetor.
            string[] nome = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for(int i =0; i<n; i++)
            {
                Console.WriteLine("Produto " + (i + 1)+":");

                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Preço de compra: ");
                precoCompra[i] = double.Parse(Console.ReadLine(), ci);

                Console.Write("Preço de venda: ");
                precoVenda[i] = double.Parse(Console.ReadLine(), ci);

            }




            //Laço para verificação dos lucros. Lucro abaixo de 10%
            // entre 10% e 20% e 20%+
            abaixo = 0;
            entre = 0;
            acima = 0;

            for(int i = 0; i < n; i++)
            {
                lucro = precoVenda[i] - precoCompra[i];
                pLucro = lucro * 100 / precoCompra[i];

                if(pLucro < 10)
                {
                    abaixo++;
                }
                else if(pLucro >=10 && pLucro <= 20)
                {
                    entre++;
                }
                else
                {
                    acima++;
                }


            }

            //Laço para verificar o total de compra e o total de vendas.
            totalCompra = 0;
            totalVenda = 0;
            for(int i =0; i < n; i++)
            {
                totalCompra = totalCompra + precoCompra[i];
                totalVenda = totalVenda + precoVenda[i];
            }

            totalLucro = totalVenda - totalCompra;


            Console.WriteLine();
            Console.WriteLine("RELATÓRIO: ");

            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", ci));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", ci));
            Console.WriteLine("Lucro Total: " + totalLucro.ToString("F2", ci));
        }
    }
}
