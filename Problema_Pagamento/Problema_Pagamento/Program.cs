using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            string nome;
            int horas;
            double valorHora,pagamento;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine(),ci);

            Console.Write("Horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            pagamento = valorHora * horas;

            Console.WriteLine("O pagamento para " + nome + " deve ser de R$" + pagamento.ToString("F2",ci)+"!");


        }
    }
}