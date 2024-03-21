using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double salarioAtual, novoSalario, aumento;
            int porcentagem;

            Console.Write("Digite o salário da pessoa: ");
            salarioAtual = double.Parse(Console.ReadLine(),ci);

            if(salarioAtual <= 1000.0)
            {
                porcentagem = 20;

                aumento = salarioAtual * porcentagem / 100;
                novoSalario = salarioAtual + aumento;
            }
            else if(salarioAtual <= 3000.0)
            {
                porcentagem = 15;
                aumento = salarioAtual * porcentagem / 100;
                novoSalario = salarioAtual + aumento;
            }
            else if(salarioAtual <= 8000.0)
            {
                porcentagem = 10;
                aumento = salarioAtual * porcentagem / 100;
                novoSalario = salarioAtual + aumento;
            }
            else
            {
                porcentagem = 5;
                aumento = salarioAtual * porcentagem / 100;
                novoSalario = salarioAtual + aumento;
            }

            Console.WriteLine("Novo Salário = R$" + novoSalario.ToString("F2", ci));
            Console.WriteLine("Aumento = R$" + aumento.ToString("F2", ci));
            Console.WriteLine("Porcentagem = " + porcentagem + "%");
        }
    }
}