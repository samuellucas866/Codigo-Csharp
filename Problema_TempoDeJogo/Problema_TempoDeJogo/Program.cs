using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int horaInicial, horaFinal, tempoJogo;

            Console.Write("Hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            horaFinal = int.Parse(Console.ReadLine());

            //Laço para verificação das horas digitadas pelo usuário.
            //Para que seja mostrada a duração dentro do jogo.
            if(horaInicial < horaFinal)
            {
                tempoJogo = horaFinal - horaInicial;
            }
            else
            {
                tempoJogo = 24-(horaInicial - horaFinal);
            }

            Console.WriteLine("O jogo durou: " + tempoJogo + " Horas");
        }
    }
}