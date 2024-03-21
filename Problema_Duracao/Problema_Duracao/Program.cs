using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            int h, m, s,totalSegundos,resto;

            Console.Write("Digite a duração em segundos: ");
            totalSegundos = int.Parse(Console.ReadLine());

            //Para pegar o total de segundos nas horas, dividir e armazerar no resto.  
            //Em seguida utiliza o resto para mostrar os valores dos minutos e segundos.
            h = totalSegundos / 3600;
            resto = totalSegundos % 3600;

            m = resto / 60;
            s = resto % 60;

            Console.WriteLine(h+":"+m+":"+s);
        }
    }
}
