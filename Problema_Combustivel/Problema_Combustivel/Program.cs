using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int codigo,alcool,gasolina,diesel;

            Console.Write("Informe um código(1,2,3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());

            //Laço para verificar o código e fazer a contagem dos tipos de combustíveis solicitados

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while(codigo != 4)
            {

               if( codigo == 1)
                {
                    alcool++;
                }
               else if(codigo == 2)
                {
                    gasolina++;
                }
                else if(codigo == 3)
                {
                    diesel++;
                }

                Console.Write("Informe um código(1,2,3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}