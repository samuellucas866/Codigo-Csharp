using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            int x, y;

            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            //Laço para informar em qual quadrante estão as coordenadas digitadas.
            //Caso seja digitado o valor 0 em X ou Y o programa irá encerrar sem mostrar nenhuma mensagem.
            while(x != 0 && y != 0)
            {
                
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante Q1");
                }
                else if(x<0 && y > 0)
                {
                    Console.WriteLine("Quadrante Q2");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante Q3");
                }
                else
                {
                    Console.WriteLine("Quadrante Q4");
                }

                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
