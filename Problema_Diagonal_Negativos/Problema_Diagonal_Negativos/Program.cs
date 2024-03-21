using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n,cont;

            Console.Write("Qual ordem da matriz: ");
            n = int.Parse(Console.ReadLine());

            //Laço para armazenar os valores dentro da Matriz.
            int[,] x = new int[n,n];

            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    Console.Write("Elemento ["+i+" , "+j+"]: ");
                    x[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            //Laço para pegar a diagonal que é a posição da linha i e coluna i
            //para mostrar os valores da diagonal.
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for(int i = 0; i<n; i++)
            {
                Console.Write(x[i, i] + " ");
            }


            //Laço para verificar os números negativos dentro da matriz.
            cont = 0;
            for(int i =0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (x[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.Write("\n Quantidade de Negativos: " + cont);

        }
    }
}