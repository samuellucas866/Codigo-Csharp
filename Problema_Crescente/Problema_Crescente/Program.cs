using System.Globalization;


namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());


            //Estrutura de repetição para verificação da ordem dos números digitados
            while(x != y)
            {
                if(x < y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DECRESCENTE");
                }

                Console.WriteLine("Digite outros dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
