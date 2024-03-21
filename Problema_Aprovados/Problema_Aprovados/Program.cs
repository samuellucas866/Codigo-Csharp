using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double media;

            Console.Write("Quantos alunos serão digitados: ");
            n = int.Parse(Console.ReadLine());

            //Laço para armazenar os dados dos alunos e suas respectivas notas.

            string[] nomes = new string[n];
            double[] n1 = new double[n];
            double[] n2 = new double[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Digite o nome, primeira e segunda nota do " + (i + 1) + "° aluno: ");
                nomes[i] = Console.ReadLine();
                n1[i] = double.Parse(Console.ReadLine(),ci);
                n2[i] = double.Parse(Console.ReadLine(),ci);
            }

            //Laço para verificar os alunos aprovados.

            Console.WriteLine("Alunos aprovados: ");

            for(int i = 0; i<n; i++)
            {

                media = (n1[i] + n2[i]) / 2;

                if(media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }               
                    
               
            }

            
            
            




        }
    }
}